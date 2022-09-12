namespace PotentioLEDParsing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_comPortSettings = new System.Windows.Forms.GroupBox();
            this.progressBar_uno = new System.Windows.Forms.ProgressBar();
            this.button_unoClose = new System.Windows.Forms.Button();
            this.button_unoOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_unoBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_unoComPort = new System.Windows.Forms.ComboBox();
            this.serialPort_uno = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar_potentioB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar_potentioA = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_led1On = new System.Windows.Forms.Button();
            this.button_led1Off = new System.Windows.Forms.Button();
            this.button_led2Off = new System.Windows.Forms.Button();
            this.button_led2On = new System.Windows.Forms.Button();
            this.button_led3Off = new System.Windows.Forms.Button();
            this.button_led3On = new System.Windows.Forms.Button();
            this.button_led4Off = new System.Windows.Forms.Button();
            this.button_led4On = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_comPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_comPortSettings
            // 
            this.groupBox_comPortSettings.Controls.Add(this.progressBar_uno);
            this.groupBox_comPortSettings.Controls.Add(this.button_unoClose);
            this.groupBox_comPortSettings.Controls.Add(this.button_unoOpen);
            this.groupBox_comPortSettings.Controls.Add(this.label2);
            this.groupBox_comPortSettings.Controls.Add(this.label1);
            this.groupBox_comPortSettings.Controls.Add(this.comboBox_unoBaudRate);
            this.groupBox_comPortSettings.Controls.Add(this.comboBox_unoComPort);
            this.groupBox_comPortSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_comPortSettings.Name = "groupBox_comPortSettings";
            this.groupBox_comPortSettings.Size = new System.Drawing.Size(329, 216);
            this.groupBox_comPortSettings.TabIndex = 2;
            this.groupBox_comPortSettings.TabStop = false;
            this.groupBox_comPortSettings.Text = "COM PORT SETTINGS";
            // 
            // progressBar_uno
            // 
            this.progressBar_uno.Location = new System.Drawing.Point(6, 180);
            this.progressBar_uno.Name = "progressBar_uno";
            this.progressBar_uno.Size = new System.Drawing.Size(317, 23);
            this.progressBar_uno.TabIndex = 6;
            // 
            // button_unoClose
            // 
            this.button_unoClose.Location = new System.Drawing.Point(166, 129);
            this.button_unoClose.Name = "button_unoClose";
            this.button_unoClose.Size = new System.Drawing.Size(114, 39);
            this.button_unoClose.TabIndex = 5;
            this.button_unoClose.Text = "CLOSE";
            this.button_unoClose.UseVisualStyleBackColor = true;
            this.button_unoClose.Click += new System.EventHandler(this.button_unoClose_Click);
            // 
            // button_unoOpen
            // 
            this.button_unoOpen.Location = new System.Drawing.Point(35, 129);
            this.button_unoOpen.Name = "button_unoOpen";
            this.button_unoOpen.Size = new System.Drawing.Size(114, 39);
            this.button_unoOpen.TabIndex = 4;
            this.button_unoOpen.Text = "OPEN";
            this.button_unoOpen.UseVisualStyleBackColor = true;
            this.button_unoOpen.Click += new System.EventHandler(this.button_unoOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM PORT:";
            // 
            // comboBox_unoBaudRate
            // 
            this.comboBox_unoBaudRate.FormattingEnabled = true;
            this.comboBox_unoBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_unoBaudRate.Location = new System.Drawing.Point(135, 91);
            this.comboBox_unoBaudRate.Name = "comboBox_unoBaudRate";
            this.comboBox_unoBaudRate.Size = new System.Drawing.Size(145, 24);
            this.comboBox_unoBaudRate.TabIndex = 1;
            // 
            // comboBox_unoComPort
            // 
            this.comboBox_unoComPort.FormattingEnabled = true;
            this.comboBox_unoComPort.Location = new System.Drawing.Point(135, 49);
            this.comboBox_unoComPort.Name = "comboBox_unoComPort";
            this.comboBox_unoComPort.Size = new System.Drawing.Size(145, 24);
            this.comboBox_unoComPort.TabIndex = 0;
            this.comboBox_unoComPort.DropDown += new System.EventHandler(this.comboBox_unoComPort_DropDown);
            // 
            // serialPort_uno
            // 
            this.serialPort_uno.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_uno_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.progressBar_potentioB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.progressBar_potentioA);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POTENTIOMETER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "POTENTIO B:";
            // 
            // progressBar_potentioB
            // 
            this.progressBar_potentioB.Location = new System.Drawing.Point(264, 112);
            this.progressBar_potentioB.Maximum = 700;
            this.progressBar_potentioB.Name = "progressBar_potentioB";
            this.progressBar_potentioB.Size = new System.Drawing.Size(426, 33);
            this.progressBar_potentioB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "POTENTIO A:";
            // 
            // progressBar_potentioA
            // 
            this.progressBar_potentioA.Location = new System.Drawing.Point(264, 62);
            this.progressBar_potentioA.Maximum = 700;
            this.progressBar_potentioA.Name = "progressBar_potentioA";
            this.progressBar_potentioA.Size = new System.Drawing.Size(426, 33);
            this.progressBar_potentioA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_led4Off);
            this.groupBox2.Controls.Add(this.button_led4On);
            this.groupBox2.Controls.Add(this.button_led3Off);
            this.groupBox2.Controls.Add(this.button_led3On);
            this.groupBox2.Controls.Add(this.button_led2Off);
            this.groupBox2.Controls.Add(this.button_led2On);
            this.groupBox2.Controls.Add(this.button_led1Off);
            this.groupBox2.Controls.Add(this.button_led1On);
            this.groupBox2.Location = new System.Drawing.Point(347, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 216);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED";
            // 
            // button_led1On
            // 
            this.button_led1On.Location = new System.Drawing.Point(26, 68);
            this.button_led1On.Name = "button_led1On";
            this.button_led1On.Size = new System.Drawing.Size(73, 42);
            this.button_led1On.TabIndex = 0;
            this.button_led1On.Text = "ON";
            this.button_led1On.UseVisualStyleBackColor = true;
            this.button_led1On.Click += new System.EventHandler(this.button_led1_Click);
            // 
            // button_led1Off
            // 
            this.button_led1Off.Location = new System.Drawing.Point(26, 129);
            this.button_led1Off.Name = "button_led1Off";
            this.button_led1Off.Size = new System.Drawing.Size(73, 42);
            this.button_led1Off.TabIndex = 1;
            this.button_led1Off.Text = "OFF";
            this.button_led1Off.UseVisualStyleBackColor = true;
            this.button_led1Off.Click += new System.EventHandler(this.button_led1Off_Click);
            // 
            // button_led2Off
            // 
            this.button_led2Off.Location = new System.Drawing.Point(129, 129);
            this.button_led2Off.Name = "button_led2Off";
            this.button_led2Off.Size = new System.Drawing.Size(73, 42);
            this.button_led2Off.TabIndex = 3;
            this.button_led2Off.Text = "OFF";
            this.button_led2Off.UseVisualStyleBackColor = true;
            this.button_led2Off.Click += new System.EventHandler(this.button_led2Off_Click);
            // 
            // button_led2On
            // 
            this.button_led2On.Location = new System.Drawing.Point(129, 68);
            this.button_led2On.Name = "button_led2On";
            this.button_led2On.Size = new System.Drawing.Size(73, 42);
            this.button_led2On.TabIndex = 2;
            this.button_led2On.Text = "ON";
            this.button_led2On.UseVisualStyleBackColor = true;
            this.button_led2On.Click += new System.EventHandler(this.button_led2On_Click);
            // 
            // button_led3Off
            // 
            this.button_led3Off.Location = new System.Drawing.Point(235, 129);
            this.button_led3Off.Name = "button_led3Off";
            this.button_led3Off.Size = new System.Drawing.Size(73, 42);
            this.button_led3Off.TabIndex = 5;
            this.button_led3Off.Text = "OFF";
            this.button_led3Off.UseVisualStyleBackColor = true;
            this.button_led3Off.Click += new System.EventHandler(this.button_led3Off_Click);
            // 
            // button_led3On
            // 
            this.button_led3On.Location = new System.Drawing.Point(235, 68);
            this.button_led3On.Name = "button_led3On";
            this.button_led3On.Size = new System.Drawing.Size(73, 42);
            this.button_led3On.TabIndex = 4;
            this.button_led3On.Text = "ON";
            this.button_led3On.UseVisualStyleBackColor = true;
            this.button_led3On.Click += new System.EventHandler(this.button_led3On_Click);
            // 
            // button_led4Off
            // 
            this.button_led4Off.Location = new System.Drawing.Point(334, 129);
            this.button_led4Off.Name = "button_led4Off";
            this.button_led4Off.Size = new System.Drawing.Size(73, 42);
            this.button_led4Off.TabIndex = 7;
            this.button_led4Off.Text = "OFF";
            this.button_led4Off.UseVisualStyleBackColor = true;
            this.button_led4Off.Click += new System.EventHandler(this.button_led4Off_Click);
            // 
            // button_led4On
            // 
            this.button_led4On.Location = new System.Drawing.Point(334, 68);
            this.button_led4On.Name = "button_led4On";
            this.button_led4On.Size = new System.Drawing.Size(73, 42);
            this.button_led4On.TabIndex = 6;
            this.button_led4On.Text = "ON";
            this.button_led4On.UseVisualStyleBackColor = true;
            this.button_led4On.Click += new System.EventHandler(this.button_led4On_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "LED 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "LED 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "LED 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "LED 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_comPortSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Potentio, LED Parsing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_comPortSettings.ResumeLayout(false);
            this.groupBox_comPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_comPortSettings;
        private System.Windows.Forms.ProgressBar progressBar_uno;
        private System.Windows.Forms.Button button_unoClose;
        private System.Windows.Forms.Button button_unoOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_unoBaudRate;
        private System.Windows.Forms.ComboBox comboBox_unoComPort;
        private System.IO.Ports.SerialPort serialPort_uno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar_potentioB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar_potentioA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_led1On;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_led4Off;
        private System.Windows.Forms.Button button_led4On;
        private System.Windows.Forms.Button button_led3Off;
        private System.Windows.Forms.Button button_led3On;
        private System.Windows.Forms.Button button_led2Off;
        private System.Windows.Forms.Button button_led2On;
        private System.Windows.Forms.Button button_led1Off;
    }
}

