using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino2560
{
    public partial class Setup : Form
    {
        public static bool setup_com=false;

        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            
            //timer1.Enabled = true;
            //timer1.Start();
            Form1.setupLoad = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            NUD_Min.Value = DateTime.Now.Minute;
            NUD_Hour.Value = (DateTime.Now.Hour);
           
            SerialPortCommunicator.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataRecieved);
           // MessageBox.Show(setup_com.ToString());
            if (setup_com == true)
            {
               // MessageBox.Show("true");
                gb_calibration.Visible = false;
             //   gb_logInterval.Visible = false;
                gb_wireLength.Visible = false;
            }
            
            //this.Location = new Point(200, 100);

        }

        private void port_DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           // throw new NotImplementedException();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           // SerialPortCommunicator.SerialPort.WriteLine("$
            //Form1 f = new Form1();
            MB_message mb = new MB_message();
           // mb.label1.Text = "Data Copied Successfully!";
         //   mb.Parent = f;
            mb.Show();


        }

        private void bt_dateTime_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();

            String dt = dateTimePicker1.Value.Year + "," + dateTimePicker1.Value.Month + "," + dateTimePicker1.Value.Day + "," + NUD_Hour.Value + "," + NUD_Min.Value +","+ DateTime.Now.Second;
            //MessageBox.Show(dt);
            SerialPortCommunicator.SerialPort.WriteLine("$106:dt:" + dt);

            MB_message mb = new MB_message();
            mb.Theme_success("Changes Saved Successfully!");
           // mb.label1.Text = "Data Copied Successfully!";
         //   mb.Parent = f;
            mb.Show();
            SerialPortCommunicator.SerialPort.WriteLine("$108:");
        }

        private void bt_logInterval_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(NUD_LogInterval.SelectedItem.ToString());
            SerialPortCommunicator.SerialPort.WriteLine("$106:log:" + NUD_LogInterval.SelectedItem.ToString());
            //Form1 f = new Form1();
            MB_message mb = new MB_message();
            // mb.label1.Text = "Data Copied Successfully!";
            //   mb.Parent = f;
            mb.Theme_success("Changes Saved Successfully!");
            mb.Show();
            SerialPortCommunicator.SerialPort.WriteLine("$108:");
           // MessageBox.Show(NUD_LogInterval.SelectedItem.ToString());
        }

        private void bt_wireLength_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$106:len:"+NUD_wireLength.Value);
            //Form1 f = new Form1();
            MB_message mb = new MB_message();
            // mb.label1.Text = "Data Copied Successfully!";
            //   mb.Parent = f;
            mb.Theme_success("Changes Saved Successfully!");
            mb.Show();
            SerialPortCommunicator.SerialPort.WriteLine("$108:");
        }

        private void bt_calCoef_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$109:" +txt_cal_a+":"+txt_cal_b);
            //Form1 f = new Form1();
            MB_message mb = new MB_message();
            // mb.label1.Text = "Data Copied Successfully!";
            //   mb.Parent = f;
            mb.Theme_success("Changes Saved Successfully!");
            mb.Show();
            SerialPortCommunicator.SerialPort.WriteLine("$108:");
        }

        private void NUD_Hour_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Hour.Value > 23)
            {
                NUD_Hour.Value = 0;
            }
            if (NUD_Hour.Value < 0)
            {
                NUD_Hour.Value = 23;
            }
        }

        private void NUD_Min_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Min.Value > 59)
            {
                NUD_Min.Value = 0;
                NUD_Hour.Value += 1;
            }
            if (NUD_Min.Value < 0)
            {
                NUD_Min.Value = 59;
                NUD_Hour.Value -= 1;
            }
        }

        private void NUD_LogInterval_ValueChanged(object sender, EventArgs e)
        {
            //if (NUD_LogInterval.Value > 24)
            //{
            //    NUD_LogInterval.Value = 6;
            //}
            //else if (NUD_LogInterval.Value == 18 )
            //{
            //    NUD_LogInterval.Value = 24;
            //}

            //if (NUD_LogInterval.Value < 6)
            //{
            //    NUD_LogInterval.Value = 24;
            //}
           
        }

        private void NUD_wireLength_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_wireLength.Value > 100)
            {
                NUD_wireLength.Value = 1;
            }
            if (NUD_wireLength.Value < 1)
            {
                NUD_wireLength.Value = 100;
            }
            if (NUD_wireLength.Value > 1)
            {
                lbl_meter.Text = "meters";
            }
            if (NUD_wireLength.Value == 1)
            {
                lbl_meter.Text = "meter";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true)
            {
                dateTimePicker1.Value = DateTime.Now;
                NUD_Min.Value = DateTime.Now.Minute;
                NUD_Hour.Value = (DateTime.Now.Hour);

                dateTimePicker1.Enabled = false;
                NUD_Hour.Enabled = false;
                NUD_Min.Enabled = false;



            }
            else
            {
                dateTimePicker1.Enabled = true;
                NUD_Hour.Enabled = true;
                NUD_Min.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // MessageBox.Show("h");
            if (SerialPortCommunicator.SerialPort.IsOpen == true)
            {
                SerialPortCommunicator.SerialPort.WriteLine("wake");
            }
        }

        private void NUD_LogInterval_onItemSelected(object sender, EventArgs e)
        {

        }

        private void NUD_LogInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NUD_LogInterval.SelectedIndex == -1)
            {
                bt_logInterval.Enabled = false;
            }
            else
            {
                bt_logInterval.Enabled = true;
            }
        }

        private void bt_apn_update_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$106:apn:" + tb_apn.Text);

            SerialPortCommunicator.SerialPort.WriteLine("$108:");
        }
    }
}
