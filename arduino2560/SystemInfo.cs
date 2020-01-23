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
    public partial class SystemInfo : Form
    {
        public static String mod, pro,dt,apn,wl,li;
        

        public SystemInfo()
        {
            InitializeComponent();
        }

        private void SystemInfo_Load(object sender, EventArgs e)
        {
            try
            {
                
                Form1.sysLoad = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               // SerialPortCommunicator.SerialPort.WriteLine("$108:");                  //this is transfered on Form1 btnsys click

                SerialPortCommunicator.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataRecieved);
            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
              //  SerialPortCommunicator.SerialPort.WriteLine("wake");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        lblModelNumber.Text = mod;
                        lblProductID.Text = pro;
                        lblSystemClock.Text = dt;
                        lblAPN.Text = apn;
                        //li.Trim();
                       // lblLogInterval.Text = li;
                        //wl.Trim();
                        lblCoeff.Text = wl ;
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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
