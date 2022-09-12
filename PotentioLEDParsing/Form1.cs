using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotentioLEDParsing
{
    public partial class Form1 : Form
    {
        string unoDataIn, dataSensor1, dataSensor2;
        sbyte indexOfA, indexOfB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_unoOpen.Enabled = true;
            button_unoClose.Enabled = false;
            progressBar_uno.Value = 0;
            progressBar_potentioA.Value = 0;
            progressBar_potentioB.Value = 0;
            comboBox_unoBaudRate.Text = "9600";
            ledControl(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort_uno.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox_unoComPort_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_unoComPort.Items.Clear();
            comboBox_unoComPort.Items.AddRange(portLists);
        }

        private void button_unoOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_uno.PortName = comboBox_unoComPort.Text;
                serialPort_uno.BaudRate = Convert.ToInt32(comboBox_unoBaudRate.Text);
                serialPort_uno.Open();

                ledControl(true);
                button_unoOpen.Enabled = false;
                button_unoClose.Enabled = true;
                progressBar_uno.Value = 100;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ledControl(bool state)
        {
            button_led1On.Enabled = state;
            button_led1Off.Enabled = state;
            button_led2On.Enabled = state;
            button_led2Off.Enabled = state;
            button_led3On.Enabled = state;
            button_led3Off.Enabled = state;
            button_led4On.Enabled = state;
            button_led4Off.Enabled = state;
        }

        private void Button_SendData (string data)
        {
            if (serialPort_uno.IsOpen)
            {
                try
                {
                    serialPort_uno.Write(data);
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void button_led1_Click(object sender, EventArgs e)
        {
            Button_SendData("1ON#");
        }

        private void button_led1Off_Click(object sender, EventArgs e)
        {
            Button_SendData("1OFF#");
        }

        private void button_led2On_Click(object sender, EventArgs e)
        {
            Button_SendData("2ON#");
        }

        private void button_led2Off_Click(object sender, EventArgs e)
        {
            Button_SendData("2OFF#");
        }

        private void button_led3On_Click(object sender, EventArgs e)
        {
            Button_SendData("3ON#");
        }

        private void button_led3Off_Click(object sender, EventArgs e)
        {
            Button_SendData("3OFF#");
        }

        private void button_led4On_Click(object sender, EventArgs e)
        {
            Button_SendData("4ON#");
        }

        private void button_led4Off_Click(object sender, EventArgs e)
        {
            Button_SendData("4OFF#");
        }

        private void button_unoClose_Click(object sender, EventArgs e)
        {
            try
            { 
                serialPort_uno.Close();
                button_unoOpen.Enabled = true;
                button_unoClose.Enabled = false;
                progressBar_uno.Value = 0;
                ledControl(false);
                progressBar_potentioA.Value = 0;
                progressBar_potentioB.Value = 0;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort_uno_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            unoDataIn = serialPort_uno.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(unoDataIn.IndexOf("A"));
                indexOfB = Convert.ToSByte(unoDataIn.IndexOf("B"));

                dataSensor1 = unoDataIn.Substring(0, indexOfA);
                dataSensor2 = unoDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);

                progressBar_potentioA.Value = Convert.ToInt32(dataSensor1);
                progressBar_potentioB.Value = Convert.ToInt32(dataSensor2);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
