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
using System.Data.OleDb;
using System.Data.Common;
using System.IO;
using Bunifu;
using Bunifu.Framework;
using BunifuAnimatorNS;
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;


namespace arduino2560
{
    public partial class Form1 : Form
    {
        public bool status=false;

        int mov;
        int movx;
        int movy;
        bool enter;
        int i = 1;
        
       int scanref = 0;

        public static bool light = false;
        public static bool setlog = false;
        public static bool notftp = false;
        public static bool all = false;
        public static bool bt_enable = false;

        public static bool setup_com= false;

        //Connect con = new Connect();
        //Setup setup = new Setup();
        //Scan scan = new Scan();
        //SystemInfo SystemInfo = new SystemInfo();
        //Analysis analysis = new Analysis();
        //BackUpData backup = new BackUpData();
        //APN apn = new APN();

   // public static string[] SD_Files = new string[100];
   // public static int dataRecieveCount = 0;
   // public static int limit = 0;
   //public static bool f = false;
    //public static int startposition = 0;
    //public static int endpostion = 0;
       // Bunifu_
        public static bool backupDataLoad = false;
        public static bool conLoad = false;
        public static bool scanLoad = false;
        public static bool setupLoad = false;
        public static bool apnLoad = false;
        public static bool sysLoad = false; 
        public static bool analLoad = false;

       

        public Form1()
        {
         
           
            
            
            InitializeComponent();
       

            

        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_version.Text += Application.ProductVersion;      // this shows the version of the software

            //if (status == true)
            //{
            //    // MessageBox.Show("Status change");
            //    //lbl_conStatus.Text = "Device Connected";
            //}
            bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 81, 136); // this change the color of connect tab, 

           timer2.Start();                                        //this timer is responsible for showing the proper fuctionallity of software according to the version of the software
            enter = true;

           // Connect con = new Connect();
           

          //  Setup setup = new Setup();
            callObjects.setup.MdiParent = this;
            callObjects.setup.Show();

            callObjects.con.MdiParent = this;
            callObjects.con.Show();
            //setup.Visible = false;

            //Scan scan = new Scan();
            //scan.MdiParent = this;
            //scan.Show();
            //scan.Visible = false;

            //SystemInfo SystemInfo = new SystemInfo();
            //SystemInfo.MdiParent = this;
            //SystemInfo.Show();
            //SystemInfo.Visible = false;


           // ManageUsers" is child form 
            //Connect _manageUsers = new Connect()
            //{
            //    MdiParent = this,
            //    Dock = DockStyle.Fill,
            //    WindowState = FormWindowState.Maximized
            //    // this.Location = Screen.AllScreens[00].WorkingArea.Location;
            //};
        }

        private void btn_comm_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_pnCon_Click(object sender, EventArgs e)
        {
          //bg color change

            bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 81, 136);

            bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 114, 188);

            if (bt_pnRefresh_bu.Visible ==  true)
            {
                bunifuTransition1.HideSync(bt_pnRefresh_bu);
            }

           // bt_pnScan_bu.Size = new Size(204, 50);


            if (conLoad == false)
            {
                callObjects.con.MdiParent = this;
                callObjects.con.Show();
            }
            else
            {


                callObjects.con.Activate();

            }


       
        }

        private void bt_pnCon_MouseHover(object sender, EventArgs e)
        {

           // i_btn_con.BackColor = Color.FromArgb(0, 136, 225);

        }

        private void i_btn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btn_close_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
           // Application.Exit();
        }

        private void bt_pnCon_MouseLeave(object sender, EventArgs e)
        {
           // i_btn_con.BackColor = Color.FromArgb(0, 114, 188);
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
          // Application.Exit();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
           // Form1 f1 = new Form1();

            this.WindowState = FormWindowState.Minimized;
          //  MessageBox.Show("Minimized");
        }

        // as it is the borderless form, this titlebar allows the windowsform to move 
        private void pnl_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;

        }

        private void pnl_TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - (movx+200), MousePosition.Y - movy);
            }
        }

        private void pnl_TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {
           
        }

        // this timers shows the terminating animation.
        private void timer1_Tick(object sender, EventArgs e)
        {
          
              i=i+15;                  
                  //  Form1 f1= new Form1();          
                         if(i<200)                           
                    this.Size = new System.Drawing.Size(521-2*i, 316-2*i);
                       
                    //MessageBox.Show(i.ToString());
                         if (i > 200)
                         {

                             if (i > 500)
                             {
                                 i = i + 10;
                             }
                             this.Location = new Point(2 * i, 130);
                         }
                         if (i >= 600)
                         {
                             // MessageBox.Show(i.ToString());

                             timer1.Stop();
                             timer1.Enabled = false;
                             Application.Exit();
                             i = 0;
                            // flag_opacity = true;
                         }
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int WS_MAXIMIZEBOX = 0x00010000;
        //        var cp = base.CreateParams;
        //        cp.Style &= ~WS_MAXIMIZEBOX;
        //        return cp;
        //    }

        //}

        private void bt_pnScan_Click(object sender, EventArgs e)
        {
            if (bt_pnRefresh_bu.Visible == false)
            {
                bunifuTransition1.ShowSync(bt_pnRefresh_bu);
            }
                bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 114, 188);

            bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 81, 136);
            bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 114, 188);

          //  bt_pnScan_bu.Size = new Size(156, 50);

            if (scanLoad == false)
            {
                callObjects.scan.MdiParent = this;
                callObjects.scan.Show();
            }
            else
            {
                // MessageBox.Show("active");

                //BUD.BackUpData_Load(this,null);

                callObjects.scan.Activate();

            }
        }

        private void bt_pnSetup_Click(object sender, EventArgs e)
        {
            bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 114, 188);

            bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 81, 136);
            bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 114, 188);


            //bt_pnScan_bu.Size = new Size(204, 50);
            if (bt_pnRefresh_bu.Visible == true)
            {
                bunifuTransition1.HideSync(bt_pnRefresh_bu);
            }
            if (setupLoad == false)
            {
               // MessageBox.Show(setup_com.ToString());
                if (setup_com == true)
                {
                   // MessageBox.Show("setup call");
                    callObjects.setup.gb_calibration.Visible = false;
                   // setup.gb_logInterval.Visible = false;
                    callObjects.setup.gb_wireLength.Visible = false;
                }
                callObjects.setup.MdiParent = this;
                callObjects.setup.Show();
            }
            else
            {

                if (setup_com == true)
                {
                  //  MessageBox.Show("setup call");
                    callObjects.setup.gb_calibration.Visible = false;
                //    setup.gb_logInterval.Visible = false;
                    callObjects.setup.gb_wireLength.Visible = false;
                }
                // MessageBox.Show("active");

                //BUD.BackUpData_Load(this,null);

                callObjects.setup.Activate();

            }
            //Setup setup = new Setup();
            //setup.MdiParent = this;
            //setup.Visible = true;
            SerialPortCommunicator.SerialPort.WriteLine("$111:start");

        }

        private void pnl_TitleBar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender,  EventArgs e)
        {
            try
            {

                if (light == true)
                {
                  //  bt_pnCon_bu.Location = new Point(1, 129);
                    try
                    {
                        //pictureBox3.Image = Image.FromFile(@"C:\Program Files (x86)\E&E Solutions Pvt Ltd\NEXT-COMM\Resources\Connected1.png");
                    }
                    catch (Exception ex)
                    {
                        //timer2.Stop();
                        //MessageBox.Show(ex.Message);

                    }
                    //bt_pnSetup_bu.Visible = true;
                    //bt_pnSys_bu.Visible = true;
                    //bt_pnBackUp_bu.Visible = true;
                    //bt_pnTele_bu.Visible = true;

                    //bunifuTransition2.HideSync(bt_pnSetup_bu);
                    //bunifuTransition3.HideSync(bt_pnSys_bu);
                    //bunifuTransition4.HideSync(bt_pnBackUp_bu);
                    //bunifuTransition5.HideSync(bt_pnTele_bu);




                }
                else if (light == false)
                {
                   // bt_pnCon_bu.Location = new Point(1, 260);
                    try
                    {
                        //pictureBox3.Image = Image.FromFile(@"C:\Program Files (x86)\E&E Solutions Pvt Ltd\NEXT-COMM\Resources\Disconnected.png");

                    }
                    catch (Exception ex)
                    {
                       // timer2.Stop();
                      //  MessageBox.Show(ex.Message);

                    }
                    //bt_pnSetup_bu.Visible = false;
                    //bt_pnSys_bu.Visible = false;
                    //bt_pnBackUp_bu.Visible = false;
                    //bt_pnTele_bu.Visible = false;

                    //bunifuTransition2.ShowSync(bt_pnSetup_bu);
                    //bunifuTransition3.ShowSync(bt_pnSys_bu);
                    //bunifuTransition4.ShowSync(bt_pnBackUp_bu);
                    //bunifuTransition5.ShowSync(bt_pnTele_bu);
                }
                if (setlog == true)
                {
                    bt_pnSetup_bu.Visible = true;
                    bt_pnBackUp_bu.Visible = true;


                    setup_com = true;
                  //  Setup set = new Setup();
                   
                   
                    timer2.Stop();
                }
                else if (notftp == true)
                {
                    bt_pnSetup_bu.Visible = true;
                    bt_pnBackUp_bu.Visible = true;
                    bt_pnSys_bu.Visible = true;

                    timer2.Stop();
                }
                else if (all == true)
                {
                    bt_pnSetup_bu.Visible = true;
                    bt_pnBackUp_bu.Visible = true;
                    bt_pnSys_bu.Visible = true;
                    bt_pnTele_bu.Visible = true;

                    timer2.Stop();
                }
            }
            catch (Exception ex)
            {
                //timer2.Stop();
                //MessageBox.Show(ex.Message);
                
            }

           
        }

        private void bt_pnSys_Click(object sender, EventArgs e)
        {
           // bt_pnScan_bu.Size = new Size(204, 50);
            try
            {

                SerialPortCommunicator.SerialPort.WriteLine("$108:");

                if (bt_pnRefresh_bu.Visible == true)
                {
                    bunifuTransition1.HideSync(bt_pnRefresh_bu);
                }
                bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 114, 188);

                bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 81, 136);
                bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 114, 188);

                if (sysLoad == false)
                {
                    callObjects.sys.MdiParent = this;
                    callObjects.sys.Show();

                }
                else
                {
                    // MessageBox.Show("active");

                    //BUD.BackUpData_Load(this,null);

                    callObjects.sys.Activate();

                }
            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
            }

           
        }

        public bool Constatus
        {
            get { return status; }
            set { status = value; }
        }

        private void bt_pnBackUp_Click(object sender, EventArgs e)
        {
            //bt_pnScan_bu.Size = new Size(204, 50);
            if (bt_pnRefresh_bu.Visible == true)
            {
                bunifuTransition1.HideSync(bt_pnRefresh_bu);
            }
            bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 114, 188);

            bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 81, 136);
            bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 114, 188);

            if (backupDataLoad == false)
            {
                callObjects.bud.MdiParent = this;
                callObjects.bud.Show();
            }
            else
            {
                // MessageBox.Show("active");

                //BUD.BackUpData_Load(this,null);

               callObjects.bud.Activate();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_pnTele_Click(object sender, EventArgs e)
        {
            //bt_pnScan_bu.Size = new Size(204, 50);
            try
            {

                SerialPortCommunicator.SerialPort.WriteLine("$110:start");
                if (bt_pnRefresh_bu.Visible == true)
                {
                    bunifuTransition1.HideSync(bt_pnRefresh_bu);
                }
                bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 114, 188);

                bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 114, 188);
                bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 81, 136);
                bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 114, 188);

                if (apnLoad == false)
                {
                    callObjects.apn.MdiParent = this;
                    callObjects.apn.Show();
                }
                else
                {
                    // MessageBox.Show("active");

                    //BUD.BackUpData_Load(this,null);

                    callObjects.apn.Activate();

                }
            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
            }
        }

        private void bt_pnScan_bu_MouseHover(object sender, EventArgs e)
        {
            bt_pnRefresh_bu.Normalcolor = Color.FromArgb(0, 135, 224);
        }

        private void tim_ScanRefresh_Tick(object sender, EventArgs e)
        {



        }

        private void bt_pnRefresh_Click(object sender, EventArgs e)
        {
            //scan.Close();
            //Scan scan1 = new Scan();
            //scan1.Show();
            
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_pnRefresh_bu_Click(object sender, EventArgs e)
        {

            Scan sc = new Scan();
            sc.scan_refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  SplashScreen sp = new SplashScreen();
           // sp.Show();
        }

        private void bunifuGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //trial_ss t = new trial_ss();
            //t.Show();
        }

        private void bt_pnAnal_bu_Click(object sender, EventArgs e)
        {
            // bt_pnScan_bu.Size = new Size(204, 50);
           
            bt_pnCon_bu.Normalcolor = Color.FromArgb(0, 114, 188);

            bt_pnScan_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSetup_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnSys_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnBackUp_bu.Normalcolor = Color.FromArgb(0, 114, 188);
            bt_pnTele_bu.Normalcolor = Color.FromArgb(0, 114, 188);


            bt_pnAnal_bu.Normalcolor = Color.FromArgb(0, 81, 136);


            if (analLoad == false)
            {
                callObjects.analysis.MdiParent = this;
                callObjects.analysis.Show();

            }
            else
            {
                // MessageBox.Show("active");

                //BUD.BackUpData_Load(this,null);

                callObjects.analysis.Activate();

            }

        }

        private void lbl_version_Click(object sender, EventArgs e)
        {

        }

        private void lbl_version_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("press form");
        }
    }
}
