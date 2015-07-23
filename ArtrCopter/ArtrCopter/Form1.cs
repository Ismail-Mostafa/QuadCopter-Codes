using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string ggg = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // M1P.Value += 10;
           // if (M1P.Value == 100) M1P.Value = 0;
            string data = serialPort1.ReadExisting();
            if (data != "")
            {
                textBox1.Text += data;
                ggg += data;
                if (textBox1.Text.IndexOf("$") > -1 && textBox1.Text.IndexOf("@") > -1)
                {
                    try
                    {
                        string[] par1 = textBox1.Text.Split('$');
                        string[] par2 = par1[1].Split('@');
                        string[] par = par2[0].Split(';');
                        textBox1.Text = "";
                        ggg = "";
                        Roll.Text = par[3];
                        RollP.Value = 90 + (int)Convert.ToDouble(par[3]);
                        Pitch.Text = par[4];
                        PitchP.Value = 90 + (int)Convert.ToDouble(par[4]);
                        Yaw.Text = par[5];
                        YawP.Value = 90 + (int)Convert.ToDouble(par[5]);

                        M1Speed.Text = par[6];
                        M1P.Value = (int)Convert.ToDouble(par[6]);
                        M2Speed.Text = par[7];
                        M2P.Value = (int)Convert.ToDouble(par[7]);
                        M3Speed.Text = par[8];
                        M3P.Value = (int)Convert.ToDouble(par[8]);
                        M4Speed.Text = par[9];
                        M4P.Value = (int)Convert.ToDouble(par[9]);
                    }
                    catch { }
                        //trh
                        //roll
                        //pitch
                        //roll
                        //pitch
                        //yaw
                        //m1
                        //
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports){
                comboBox1.Items.Add(port);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 115200;
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            button2.Enabled = false;
            button1.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
