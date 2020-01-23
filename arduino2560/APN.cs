using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.IO;


namespace arduino2560
{
    public partial class APN : Form
    {
        String s = "";
        bool visit=false;
        public static String DataApn;
        public static String DataRec;
        public static String ftp_username, ftp_password, ftp_host;
        int click_count1=0, click_count2=0;
       // public static String DataSig;
        public APN()
        {
            InitializeComponent();
        }

        private void APN_Load(object sender, EventArgs e)
        {
            try
            {
                //timer1.Enabled = true;
                //timer1.Start();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Form1.apnLoad = true;
                SerialPortCommunicator.SerialPort.WriteLine("$110:start");





                //if (!SerialPortCommunicator.SerialPort.IsOpen)
                //{

                //    SerialPortCommunicator.SerialPort.BaudRate = 9600;
                //    // messagebox.show(nm);
                //    //   SerialPortCommunicator.SerialPort.portname = convert.tostring("com8");
                //    SerialPortCommunicator.SerialPort.PortName = Connect.portName;
                //    SerialPortCommunicator.SerialPort.Open();
                //    // SerialPortCommunicator.SerialPort.writeline("$101:start$");
                //    SerialPortCommunicator.SerialPort.DiscardOutBuffer();
                //    SerialPortCommunicator.SerialPort.DiscardInBuffer();
                //}
                SerialPortCommunicator.SerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);
                //   SerialPortCommunicator.SerialPort.ErrorReceived += new SerialErrorReceivedEventHandler(port_ErrorRecieved);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;


                ////listBox1.Visible = true;

                //String s = (SerialPortCommunicator.SerialPort.ReadLine());

            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
                //MessageBox.Show(ex.Message);
            }

        }

        void port_DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
              
             

                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                      //  MessageBox.Show("DataREc");

                        textBox2.Text = ftp_username;
                        textBox3.Text = ftp_password;
                        textBox4.Text = ftp_password;
                        textBox5.Text = ftp_host;

                        textBox1.Text = DataApn;

                        if(visit==false)
                        {
                          //  textBox1.Text = SerialPortCommunicator.SerialPort.ReadTo(":$");
                          
                            visit=true;
                        }
                    //    s = SerialPortCommunicator.SerialPort.ReadLine();
                        //String buf = SerialPortCommunicator.SerialPort.ReadLine();
                     //   MessageBox.Show(s);

                   if(DataRec!=null && DataRec.Contains("net:"))
                   {
                     //   MessageBox.Show(DataRec);

                      DataRec= DataRec.Remove(0, DataRec.LastIndexOf(":")+1);
                      //MessageBox.Show(s);
                      lbl_carrierName.Visible = true;
                      lbl_carrierName.Text= DataRec;
                      pictureBox1.Visible = false;
                      pictureBox2.Visible = true;
                     // lbl_plzWait.Visible = false;
                      bunifuiOSSwitch1.Enabled = true;
                      btn_SendData.Enabled = true;

                      if (btn_SendData.Visible == false)
                      {
                          bunifuTransition2.ShowSync(btn_SendData);
                      }
                   }
                   if (DataRec != null &&  DataRec.Contains("stren:"))
                   {
                     //  MessageBox.Show(DataRec);
                       DataRec = DataRec.Remove(0, DataRec.LastIndexOf(":") + 1);
                      // pictureBox2.Visible = true;
                       double a = Convert.ToInt32(DataRec);
                       try
                       {
                           if (a < 10)
                           {

                               var img = new Bitmap(arduino2560.Properties.Resources._1);
                               pictureBox2.Image = img;
                           }
                           else if (a < 15)
                           {
                               Image img = new Bitmap(arduino2560.Properties.Resources._2);
                               pictureBox2.Image = img;
                           }
                           else if (a < 20)
                           {
                               Image img = new Bitmap(arduino2560.Properties.Resources._3);
                               pictureBox2.Image = img;
                           }
                           else if (a < 25)
                           {
                               Image img = new Bitmap(arduino2560.Properties.Resources._4);
                               pictureBox2.Image = img;
                           }
                           else if (a < 35)
                           {
                               Image img = new Bitmap(arduino2560.Properties.Resources._5);
                               pictureBox2.Image = img;
                           }
                           else if (a == 99)
                           {
                               Image img = new Bitmap(arduino2560.Properties.Resources.sim_card_1052654);
                               pictureBox2.Image = img;
                           }
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show(ex.Message);
                       }
                     //  a = (a / 30)*100;
                      
                    //   MessageBox.Show("a: " + a.ToString() + " b: " + b.ToString() + " c: " + c.ToString());

                      // lbl_SigStren.Text ="Signal Strength: "+s+"/35";
                       //bunifuProgressBar1.Visible = true;
                       //bunifuProgressBar1.Value = (int)a;

                   }//
                    //    SerialPortCommunicator.SerialPort.ReadTimeout = 10000;
                      //  String buff = SerialPortCommunicator.SerialPort.ReadLine();

                  





                        //s.Trim();
                        //MessageBox.Show(s.Length.ToString());
                        //if (s.Length!=1)
                        //{
                        //   // MessageBox.Show((s = s.Substring(0, s.IndexOf(":"))));
                        //  //  MessageBox.Show("hai");
                        //}
                       


                    }
                    ));

                }
                else
                {

                 
                }
                // 
            }
            catch (TimeoutException t)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // MessageBox.Show("h");
            SerialPortCommunicator.SerialPort.WriteLine("wake");
        }

        private void btn_TOM_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$110:TurnOn");
            pictureBox1.Visible = true;
          //  lbl_plzWait.Visible = true;

        }

        private void btn_TurnOff_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$110:TurnOff");
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                SerialPortCommunicator.SerialPort.WriteLine("$110:TurnOn");
                pictureBox1.Visible = true;
             //   lbl_plzWait.Visible = true;
                bunifuiOSSwitch1.Enabled = false;
                if (!groupBox3.Visible)
                {
                    bunifuTransition2.ShowSync(groupBox3);
                   
                }
            }
            else
            {
                lbl_carrierName.Visible = false;
                pictureBox2.Visible = false;
                SerialPortCommunicator.SerialPort.WriteLine("$110:TurnOff");
                if (groupBox3.Visible)
                {
                    bunifuTransition2.HideSync(groupBox3);
                    bunifuTransition2.HideSync(btn_SendData);
                }
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SendData_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            btn_SendData.Enabled = false;
            bunifuiOSSwitch1.Enabled = false;

            SerialPortCommunicator.SerialPort.WriteLine("$110:send");
        }

        private void bt_dateTime_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$110:apn:" + textBox1.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text && textBox3.Text != "" && textBox2.Text != "" && textBox5.Text != "")
            {
                btn_update.Enabled = true;
              
            }
            else
            {
                btn_update.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text && textBox3.Text != "" && textBox2.Text != "" && textBox5.Text != "")
            {
                btn_update.Enabled = true;
              
            }
            else
            {
                btn_update.Enabled = false;
            }
        }

        private void bt_apn_update_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$110:apn:" + textBox1.Text);

            SerialPortCommunicator.SerialPort.WriteLine("$108:");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text && textBox3.Text != "" && textBox2.Text != "" && textBox5.Text != "")
            {
                btn_update.Enabled = true;
              
            }
            else
            {
                btn_update.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$112:" + textBox2.Text + ":" + textBox3.Text + ":" + textBox5.Text);
        }

        private void pb_eye1_Click(object sender, EventArgs e)
        {

        }

        private void bt_pass_vis1_Click(object sender, EventArgs e)
        {
            click_count1++;
            if (click_count1 % 2 != 0)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void bt_pass_vis2_Click(object sender, EventArgs e)
        {
            click_count2++;
            if (click_count2 % 2 != 0)
            {
                textBox4.UseSystemPasswordChar = false;

            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }
    }
}
