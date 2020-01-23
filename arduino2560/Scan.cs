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
    public partial class Scan : Form
    {
       int i = 0;

        
        public static String dateTime;
        public Scan()
        {
            InitializeComponent();
        }

        private void Scan_Load(object sender, EventArgs e)
        {
            try
            {

                GotFocus += Scan_GotFocus;
                LostFocus += Scan_LostFocus;
                Activated += Scan_Activated;
                Deactivate += Scan_Deactivate;
                Form1.scanLoad = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                timer1.Start();
                SerialPortCommunicator.SerialPort.WriteLine("$107:start");

                SerialPortCommunicator.SerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);

            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
            }
            
        }

        void Scan_Deactivate(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            callObjects.con.timer1.Interval = 30000;
        }

        void Scan_Activated(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            callObjects.con.timer1.Interval = 2000;
        }

        void Scan_LostFocus(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            callObjects.con.timer1.Interval = 30000;
        }

        void Scan_GotFocus(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            callObjects.con.timer1.Interval = 2000;
        }

        public void scan_refresh()
        {
            try
            {
                label2.Visible = false;
                label3.Visible = false;
               // bunifuProgressBar1.Value = 0;

                i = 0;

                timer1.Start();
                SerialPortCommunicator.SerialPort.WriteLine("$107:start");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (i < 100)
            {
                i++;
                bunifuProgressBar1.Value = i;
               
               
            }
            else
            {
                label2.Visible = true;
                label3.Visible = true;
              
                timer1.Stop();
            }
         
        }

        private void bunifuCustomLabel1_MouseHover(object sender, EventArgs e)
        {
         
          
          //  this.Font.Size = new System.Drawing.Size
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            //int fntSIze = 60;
            //this.Font = new Font(this.Font.FontFamily, fntSIze);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            SerialPortCommunicator.SerialPort.WriteLine("wake");
        }

        void port_DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {



                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                      //  MessageBox.Show(dateTime);

                      //  lbl_dateTime.Text = dateTime;



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

        private void pb_ref1_Click(object sender, EventArgs e)
        {
            scan_refresh();
        }

        private void pb_ref2_Click(object sender, EventArgs e)
        {
            scan_refresh();
        }
    }
}
