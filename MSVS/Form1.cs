using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading.Thread;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;
using System.Drawing.Drawing2D;
//using System.ArgumentOutOfRangeException;
namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DrawGraph();
            //перечислим список доступных COM портов системы:
            ComPorts_comboBox.Items.Clear();
            foreach (string portName in SerialPort.GetPortNames())
            {
                ComPorts_comboBox.Items.Add(portName);
            }
            ComPorts_comboBox.SelectedIndex = 1;
        }
        /*private double F(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            //return x = Math.Sin(x) / x;
            //return x = Convert.ToDouble(label1.Text);
            //return x = Math.Abs(var);
            //return double.TryParse(serialPort1.ReadExisting(), out x);
        }*/

        //private double var;
        private byte[] buff = new byte[10000];
        private int offs=0, cnt = 256, treshold = 0x8000; // UART_BUF_SIZE == 128
        private double x = 0, x_div = 0.14, y_div = 1, y_div_view = 1, x_div_view = 1;

        private void connectButton_Click_1(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = ((string)ComPorts_comboBox.SelectedItem);
                connectButton.Text = "Подключен";
                connectButton.BackColor = Color.GreenYellow;
                serialPort1.Open();
                // Удаляет данные из буфера приема последовательного драйвера.
                serialPort1.DiscardInBuffer();
                // Удаляет данные из буфера передачи последовательного драйвера.
                serialPort1.DiscardOutBuffer();
                serialPort1.Write("1");
            }
            else
            {
                connectButton.Text = "Подключить";
                connectButton.BackColor = Color.LightGray;
                // Удаляет данные из буфера приема последовательного драйвера.
                serialPort1.DiscardInBuffer();
                // Удаляет данные из буфера передачи последовательного драйвера.
                serialPort1.DiscardOutBuffer();
                serialPort1.Close();
                //DrawGraph();
            }
        }

        // Что бы обеспечить прием данных для lable:
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate));
            //label1.Text = serialPort1.ReadExisting();
        }
     
        private void DoUpdate(object s, EventArgs e)
        {
            //label1.Text = serialPort1.ReadExisting(); // И вот только теперь нормально считывается в label1
            //DrawGraph();
            //var = serialPort1.ReadExisting();
            //cnt = serialPort1.ReadBufferSize;
            serialPort1.Read(buff, offset: offs, count: cnt);
            //label1.Text = Convert.ToString(var);

            //Random rnd = new Random();
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;

            //System.Drawing.Color Color_curve = Color.Blue;

            // Изменим тест надписи по оси X
            pane.XAxis.Title.Text = "Time";
            // Изменим параметры шрифта для оси X
            pane.XAxis.Title.FontSpec.IsUnderline = true;
            pane.XAxis.Title.FontSpec.IsBold = false;
            pane.XAxis.Title.FontSpec.FontColor = Color.Blue;
            //pane.XAxis.Title.FontSpec.Size = 0;

            // Изменим текст по оси Y
            pane.YAxis.Title.Text = "U,mV";
            pane.YAxis.Title.FontSpec.IsUnderline = true;
            pane.YAxis.Title.FontSpec.IsBold = false;
            pane.YAxis.Title.FontSpec.FontColor = Color.Blue;
            pane.YAxis.Scale.FontSpec.Size = 1;

            // Изменим текст заголовка графика
            pane.Title.Text = "Scope";
            // В параметрах шрифта сделаем заливку красным цветом
            pane.Title.FontSpec.Fill.Brush = new SolidBrush(Color.Gray);
            pane.Title.FontSpec.Fill.IsVisible = true;

            // Сделаем шрифт не полужирным
            pane.Title.FontSpec.IsBold = false;
            //pane.CurveList.Clear();
            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin_limit = 0;
            double xmax_limit = 10;

            double ymin_limit = 0;
            double ymax_limit = 3000;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            //pane.CurveList.Clear();

            UInt16 y = 0;
            double value = 0;

            for (int i = offs; i < cnt; i++) // прочёсываем буфер UART
            {
                y = (Byte)(buff[i]); // ставим 2 быйта из UART в 16-бит Y
                i++;
                y |= (UInt16)(buff[i] << 8);

                if (x == 0) // начало координат: будем подгонять сигнал под treshold
                    {
                    if (value == 0) // ищем начало кадра
                    {
                        //bit = (UInt16)(y & (1 << 15)); // взяли 15й бит ADC
                        if ((y >= treshold) && (y < (treshold + 5000)))  // 32768 <= y < 32768 + 5000
                        {
                            //i_ = i;       // запомнили индекс
                            value = y;      // запомнили величину АЦП
                                            //pane.CurveList.Clear(); // Очистим список кривых
                        }
                    }
                    if ((value > 0) && (y > value)) // если следующая величина АЦП и сигнал нарастает
                    {
                        value = (UInt16)((ymax_limit * y_div * value) / 65635);
                        list.Add(x, value); // добавим в список точку
                        x += x_div;
                        y = (UInt16)((ymax_limit * y_div * y) / 65635);
                        list.Add(x, y); // добавим в список точку
                        x += x_div;
                    }
                }
                else // x > 0
                {
                    if (y > 0) // буфер uart не пуст и после порога
                    {
                        y = (UInt16)((ymax_limit * y_div * y) / 65635);
                        list.Add(x, y); // добавим в список точку
                        //list.Insert(0, x, y); // Заполняем список точек
                        x += x_div;
                        //x = (xmax_limit * x_div) / x;
                    }
                    else break;
                }
                if (x > xmax_limit) // предел по x
                {
                    pane.CurveList.Clear(); // Очистим список кривых
                    value = 0;
                    x = 0;
                    break;
                }
            }
            /*offs += cnt;
            //offs = 0;
            if (offs > 500)
            {
                offs = 0;
            }*/
            //label1.Text = serialPort1.ReadExisting();
            label2.Text = Convert.ToString((UInt16) ((ymax_limit * treshold) / 65635));
            label_Time.Text = Convert.ToString(x_div_view); // цена деления клетки x
            label_U.Text = Convert.ToString(y_div_view * 500); // цена деления клетки y
            //label2.Text = Convert.ToString((UInt16)((ymax_limit * treshold) / 65635));

            // Удаляет данные из буфера приема последовательного драйвера.
            //serialPort1.DiscardInBuffer();
            // Удаляет данные из буфера передачи последовательного драйвера.
            //serialPort1.DiscardOutBuffer();

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("", list, Color.Red, SymbolType.None);

            myCurve.Line.Width = 2;

            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям, ...
            pane.XAxis.MajorGrid.DashOn = 10;

            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;

            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;


            // Включаем отображение сетки напротив мелких рисок по оси X
            pane.YAxis.MinorGrid.IsVisible = true;

            // Задаем вид пунктирной линии для крупных рисок по оси Y:
            // Длина штрихов равна одному пикселю, ...
            pane.YAxis.MinorGrid.DashOn = 1;

            // затем 2 пикселя - пропуск
            pane.YAxis.MinorGrid.DashOff = 2;

            // Включаем отображение сетки напротив мелких рисок по оси Y
            pane.XAxis.MinorGrid.IsVisible = true;

            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 2;

            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = xmin_limit;
            pane.XAxis.Scale.Max = xmax_limit;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = ymin_limit;
            pane.YAxis.Scale.Max = ymax_limit;

            // Включим сглаживание
            //myCurve.Line.IsSmooth = true;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();

            /*if (x > xmax_limit)
            {
                pane.CurveList.Clear(); // Очистим список кривых
                value = 0;
                x = 0;
            }*/

            System.Threading.Thread.Sleep(40); // 10ms
            serialPort1.Write("1"); // запрашиваем данные
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            treshold += 5000;
            if (treshold > (0xFFFF - 5000)) // 65535 - 5000
            {
                treshold = 0xFFFF;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            treshold -= 5000;
            if (treshold < 0)
            {
                treshold = 0;
            }
        }

        private void label_U_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void time_plus_Click(object sender, EventArgs e)
        {
            x_div /= 2;         // коэфф для Ч, *ms
            x_div_view *= 2;    // Цена деления
        }

        private void time_minus_Click(object sender, EventArgs e)
        {
            x_div *= 2;         // коэфф для Ч, *ms
            x_div_view /= 2;    // Цена деления

        }

        private void U_plus_Click(object sender, EventArgs e)
        {
            y_div /= 2;          // коэфф для У, *mV
            y_div_view *= 2;
            if (y_div_view > 4)  // Если цена деления больше 4000mV
            {
                y_div_view = 10; // 5000mV
                y_div = 0.125;   // коэфф для У
            }
        }

        private void U_minus_Click(object sender, EventArgs e)
        {
            if (y_div_view > 4) // Если была цена деления 5000mV
            {
                y_div_view = 4; // 2000mV
            }
            else
            {
                y_div_view /= 2;
            }
                y_div *= 2;     // коэфф для У
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            

        }

        private void saveAsBitmapBtn_Click_Click(object sender, EventArgs e)
        {
            // Для сохранения картинки всего компонента ZedGraphControl
            // достаточно вызвать метод SaveAsBitmap().
            // Создание и показ диалога выбора имени файла возьмет на себя ZedGraphControl
            zedGraph.SaveAsBitmap();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
