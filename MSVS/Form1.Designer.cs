namespace Graph
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ComPorts_comboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.saveAsBitmapBtn_Click = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.time_minus = new System.Windows.Forms.Button();
            this.time_plus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_U = new System.Windows.Forms.Label();
            this.U_minus = new System.Windows.Forms.Button();
            this.U_plus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.AutoSize = true;
            this.zedGraph.Location = new System.Drawing.Point(1, 44);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(658, 553);
            this.zedGraph.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // ComPorts_comboBox
            // 
            this.ComPorts_comboBox.FormattingEnabled = true;
            this.ComPorts_comboBox.Location = new System.Drawing.Point(148, 12);
            this.ComPorts_comboBox.Name = "ComPorts_comboBox";
            this.ComPorts_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ComPorts_comboBox.TabIndex = 2;
            this.ComPorts_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.LightGray;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.Location = new System.Drawing.Point(26, 9);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(116, 29);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Подключить";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // saveAsBitmapBtn_Click
            // 
            this.saveAsBitmapBtn_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsBitmapBtn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAsBitmapBtn_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveAsBitmapBtn_Click.Location = new System.Drawing.Point(676, 556);
            this.saveAsBitmapBtn_Click.Name = "saveAsBitmapBtn_Click";
            this.saveAsBitmapBtn_Click.Size = new System.Drawing.Size(102, 32);
            this.saveAsBitmapBtn_Click.TabIndex = 4;
            this.saveAsBitmapBtn_Click.Text = "Сохранить";
            this.saveAsBitmapBtn_Click.UseVisualStyleBackColor = true;
            this.saveAsBitmapBtn_Click.Click += new System.EventHandler(this.saveAsBitmapBtn_Click_Click);
            // 
            // button_plus
            // 
            this.button_plus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(721, 383);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(36, 42);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_minus.AutoSize = true;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(722, 455);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(35, 41);
            this.button_minus.TabIndex = 6;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(752, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(659, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trig, mV:";
            // 
            // label_Time
            // 
            this.label_Time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Yellow;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Time.Location = new System.Drawing.Point(752, 268);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(20, 24);
            this.label_Time.TabIndex = 11;
            this.label_Time.Text = "0";
            // 
            // time_minus
            // 
            this.time_minus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.time_minus.AutoSize = true;
            this.time_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_minus.Location = new System.Drawing.Point(722, 295);
            this.time_minus.Name = "time_minus";
            this.time_minus.Size = new System.Drawing.Size(35, 41);
            this.time_minus.TabIndex = 10;
            this.time_minus.Text = "-";
            this.time_minus.UseVisualStyleBackColor = true;
            this.time_minus.Click += new System.EventHandler(this.time_minus_Click);
            // 
            // time_plus
            // 
            this.time_plus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.time_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_plus.Location = new System.Drawing.Point(721, 223);
            this.time_plus.Name = "time_plus";
            this.time_plus.Size = new System.Drawing.Size(36, 42);
            this.time_plus.TabIndex = 9;
            this.time_plus.Text = "+";
            this.time_plus.UseVisualStyleBackColor = true;
            this.time_plus.Click += new System.EventHandler(this.time_plus_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(659, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time, ms:";
            // 
            // label_U
            // 
            this.label_U.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_U.AutoSize = true;
            this.label_U.BackColor = System.Drawing.Color.Yellow;
            this.label_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_U.Location = new System.Drawing.Point(752, 116);
            this.label_U.Name = "label_U";
            this.label_U.Size = new System.Drawing.Size(20, 24);
            this.label_U.TabIndex = 15;
            this.label_U.Text = "0";
            this.label_U.Click += new System.EventHandler(this.label_U_Click);
            // 
            // U_minus
            // 
            this.U_minus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.U_minus.AutoSize = true;
            this.U_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.U_minus.Location = new System.Drawing.Point(722, 143);
            this.U_minus.Name = "U_minus";
            this.U_minus.Size = new System.Drawing.Size(35, 41);
            this.U_minus.TabIndex = 14;
            this.U_minus.Text = "-";
            this.U_minus.UseVisualStyleBackColor = true;
            this.U_minus.Click += new System.EventHandler(this.U_minus_Click);
            // 
            // U_plus
            // 
            this.U_plus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.U_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.U_plus.Location = new System.Drawing.Point(721, 71);
            this.U_plus.Name = "U_plus";
            this.U_plus.Size = new System.Drawing.Size(36, 42);
            this.U_plus.TabIndex = 13;
            this.U_plus.Text = "+";
            this.U_plus.UseVisualStyleBackColor = true;
            this.U_plus.Click += new System.EventHandler(this.U_plus_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(679, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "U, mV:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label_U);
            this.Controls.Add(this.U_minus);
            this.Controls.Add(this.U_plus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.time_minus);
            this.Controls.Add(this.time_plus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.saveAsBitmapBtn_Click);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ComPorts_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Scope Serial port";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComPorts_comboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button saveAsBitmapBtn_Click;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Button time_minus;
        private System.Windows.Forms.Button time_plus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_U;
        private System.Windows.Forms.Button U_minus;
        private System.Windows.Forms.Button U_plus;
        private System.Windows.Forms.Label label7;
    }
}

