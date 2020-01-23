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
using System.Diagnostics;


namespace arduino2560
{
    public partial class Connect : Form
    {
     //   private string Nm;
        wait_window ww = new wait_window();
        int clickcount = 0;
        string selectedPort = "";
        int copied_file;
        int loading_step = 0;
        delegate void SetTextCallback(string text);
        delegate void SetTextRainCallback(string text);
        private bool connecting = false;

        double lastHourRain, previousRain, thisRain;
        int lastHour = 0;
        static bool changeValue = true;
        String s,fileData,filename,end,terminate;
        System.Timers.Timer _timer;
        bool validate = true;
        String data;
        public static string portName = "";
      //  BackUpData ths;

        public Connect()
        {
            InitializeComponent();

           // ths = frm;

        }

        private void pnl_Connect_Paint(object sender, PaintEventArgs e)
        {

        }


      

        private void Connect_Load(object sender, EventArgs e)
        {
            this.FormClosing += Connect_FormClosing;
            timer2.Start();
            timer2.Enabled = true;
            timer_port.Start();                     // this timer refreshes the com ports 
            timer_port.Enabled = true;
            

            Form1.conLoad = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         
            //-----------------------------------it adds the available ports in combo box ----------------------------
            try
            {
                // this add the available com ports to the dropdown panel
                foreach (String port in SerialPort.GetPortNames())
                {
                    cboPorts.Items.Add(port);
                }
                cboPorts.SelectedIndex = 0;
                cboPorts.DropDownStyle = ComboBoxStyle.DropDownList;
           
            }
            catch (Exception ex)
            {
              
            }
        }

        void Connect_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }

        // this changes the connecting status of the software with the device
        private void btn_connect_Click(object sender, EventArgs e)
        {

                try
                {
                    btn_connect2.EnabledBGColor = Color.DodgerBlue;
                    backgroundWorker1.RunWorkerAsync(100);
                }
                catch (Exception ex)
                {
                    MB_message mb = new MB_message();
                    mb.Theme_error(ex.Message);
                    mb.Show();
                }
           
       }

        private void port_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            //if (validate == false)
            //{

            try
            {


                if (InvokeRequired)
                {
                        this.Invoke(new MethodInvoker(delegate
                        {

                            try
                            {

                                SerialPortCommunicator.SerialPort.ReadTimeout = 25000;
                                data = SerialPortCommunicator.SerialPort.ReadLine();
                               // MessageBox.Show("1"+data);
                                //}
                              data=  data.Trim();
                                //data=data.Substring(0,data.IndexOf("@");
                              if (data.Contains("$close_msg"))
                              {
                                  ww.Close();
                                  SerialPortCommunicator.SerialPort.WriteLine("$101:wake");           // this sends the wake to the device program just to begin the connection
                                  System.Threading.Thread.Sleep(10);
                                  SerialPortCommunicator.SerialPort.WriteLine("$101:Start$");
                              }
                                

                              

                                if (data.Contains("@"))
                                {
                                    data=data.Remove(0,data.IndexOf("@"));
                                   // MessageBox.Show(data);
                                    String choice = (data.Substring(data.IndexOf('@') + 1, data.IndexOf(':') - 1));
                                    // MessageBox.Show(choice);
                                    data = data.Remove(0, data.IndexOf(':') + 1);

                                    //  MessageBox.Show(data);

                                    switch (choice)
                                    {
                                        case "99":
                                            {
                                                try
                                                {
                                                    BackUpData bud = new BackUpData();
                                                    callObjects.bud.richTextBox1.Text += "Enters in case\n";
                                                    string directoryName = Environment.GetEnvironmentVariable("windir")+@"\Next-Comm";
                                                    if (data.Contains("filename"))
                                                    {
                                                        data = data.Remove(0, data.IndexOf(":") + 1);
                                                        filename = data;
                                                        validate = true;

                                                        if (!System.IO.File.Exists(directoryName))
                                                        {
                                                            System.IO.Directory.CreateDirectory(directoryName);
                                                        }
                                                        filename = filename.Trim();
                                                        callObjects.bud.richTextBox1.Text += "Data:"+filename+"\n";

                                                    }
                                                    else if (fileData.Contains("filename"))
                                                    {
                                                        data = data.Remove(0, data.IndexOf(":") + 1);
                                                        filename = data;
                                                        validate = true;

                                                        if (!System.IO.File.Exists(directoryName))
                                                        {
                                                            System.IO.Directory.CreateDirectory(directoryName);
                                                        }
                                                        filename = filename.Trim();
                                                        callObjects.bud.richTextBox1.Text +="fileData:"+ filename + "\n";
                                                    }
                                                    //callObjects.bud.lbl_filename.Visible = true;
                                                    //callObjects.bud.lbl_filename.Text = "| Copying: " + filename;
                                                    StreamWriter fileWriter = new StreamWriter(directoryName + @"\" + filename);

                                                   
                                                    callObjects.bud.lbl_filename.Visible = true;
                                                    callObjects.bud.lbl_filename.Text = "| Copying: " + filename;
                                                    callObjects.bud.label3.Visible = true;
                                                    callObjects.bud.lbl_remainging.Visible = true;
                                                   // System.Threading.Thread.Sleep(40);
                                                    callObjects.bud.richTextBox1.Text += "Starts Writing file Content..\n";
                                                    while (true)
                                                    {
                                                        loading_step++;
                                                        SerialPortCommunicator.SerialPort.ReadTimeout = 15000;
                                                        fileData = SerialPortCommunicator.SerialPort.ReadLine();
                                                      //  System.Threading.Thread.Sleep(1);
                                                        if (fileData.Contains("?+end"))
                                                        {
                                                      
                                                            BackUpData.progress += BackUpData.intervals;
                                                            BackUpData.SF_Count = 0;
                                                            break;

                                                        }
                                                     fileWriter.Write(fileData);


                                                     callObjects.bud.richTextBox1.Text += "#";
                                                     if (loading_step % 31 == 0)
                                                        {
                                                            
                                                            if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying......")
                                                            {
                                                               // MessageBox.Show("YES");

                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_2;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                            else if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying")
                                                            {
                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying.";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_3;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                            else if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying.")
                                                            {
                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying..";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_4;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                            else if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying..")
                                                            {
                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying...";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_5;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                            else if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying...")
                                                            {
                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying....";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_6;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                            else if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying....")
                                                            {
                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying.....";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_7;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                            else if (callObjects.bud.lbl_wait.Text == "| Please wait your files are copying.....")
                                                            {
                                                                callObjects.bud.lbl_wait.Text = "| Please wait your files are copying......";
                                                                callObjects.bud.pictureBox1.Image = arduino2560.Properties.Resources.loading_8;
                                                                callObjects.bud.richTextBox1.Text += "@";
                                                            }
                                                        }

                                                    }

                                                    callObjects.bud.richTextBox1.Text += "saving file..\n";
                                                   
                                                    callObjects.bud.pictureBox1.Visible = true;
                                                    fileWriter.Close();
                                                    copied_file++;

                                                    callObjects.bud.lbl_remainging.Text = (Convert.ToInt32(callObjects.bud.lbl_remainging.Text) - 1).ToString();
                                                    callObjects.bud.lbl_copied_count.Text = (copied_file).ToString();
                                                  
                                                    // fileWriter.Dispose();
                                                    // MessageBox.Show("fileclose");
                                                    // BackUpData.n++;






                                                }
                                                catch (Exception ex2)
                                                {
                                                    //  MessageBox.Show(ex2.Message);
                                                    MB_message mb = new MB_message();
                                                    mb.Theme_error(ex2.Message);
                                                    mb.Show();

                                                    //ErrMessage er = new ErrMessage();
                                                    //er.label2.Text = ex2.Message;
                                                    //er.label2.Font = new Font("Century Gothic", 11);
                                                    //er.Show();
                                                }
                                                break;
                                            }
                                        case "100":
                                            {

                                                if (data.Contains("#!"))
                                                {

                                                    // MessageBox.Show("Enter");
                                                    MB_message mb = new MB_message();
                                                
                                                    mb.Theme_error("Internal memory not found");
                                                  
                                                    mb.Show();
                                                    BackUpData bud1 = new BackUpData();
                                                    bud1.bt_BackUp.Enabled = false;
                                                    //bt_BackUp.BackColor = Color.Gray;
                                                    //lbl_MissingError.Visible = true;
                                                    label2.Visible = false;


                                                    // lbl_MissingError.Text = "Can't access SD card. There is no SD card in SD slot, or may be it is corrupted";
                                                }
                                                break;
                                            }

                                        case "101":
                                            {

                                                if (data.Contains("terminate"))
                                                {
                                                    terminate = "terminate";
                                                    MB_message mb = new MB_message();

                                                    mb.Theme_success("Data Copied Successfully");
                                                    mb.Show();

                                                   
                                                    callObjects.con.timer1.Start();             //just for the sake of uninterupted data transfer, timer1 is stoped on backup data button click , so after copying it starts again

                                                    callObjects.bud.lbl_filename.Visible = false;
                                                    callObjects.bud.label3.Visible = false;
                                                    callObjects.bud.lbl_CopyingFiles.Visible = false;
                                                    callObjects.bud.lbl_wait.Visible = false;
                                                    callObjects.bud.lbl_remainging.Visible = false;
                                                    callObjects.bud.label4.Visible = false;
                                                    callObjects.bud.lbl_copied_count.Visible = false;
                                                    callObjects.bud.pictureBox1.Visible = false;
                                                    BackUpData.progress = 100;
                                                  //  callObjects.bud.lbl_filename.Text = "Progress: 100%";
                                                    validate = false;
                                                    copied_file = 0;
                                                    Process.Start("explorer.exe", Environment.GetEnvironmentVariable("windir")+@"\Next-Comm");
                                                    break;

                                                   

                                                }
                                                else if (data.Contains("?+end"))
                                                {
                                                    end = "?+end";
                                                }
                                                break;
                                            }
                                        case "102":
                                            {
                                                MessageBox.Show(data);
                                                break;
                                            }
                                        case "103":
                                            {

                                                BackUpData.DataRec = "@" + data;
                                                break;
                                            }
                                        case "104":
                                            {

                                                break;
                                            }
                                        case "105":
                                            {

                                                break;
                                            }
                                        case "106":
                                            {

                                                break;
                                            }
                                        case "107":
                                            {
                                                if (data.Contains("^2"))
                                                {
                                                  data=  data.Replace("^2", "²");
                                                }
                                                if (data.Contains("*C"))
                                                {
                                                  data=  data.Replace("*C", "°C");
                                                }
                                                if (data.Contains("*F"))
                                                {
                                                   data= data.Replace("*F", "°F");
                                                }

                                                if (data.Contains("dt"))
                                                {
                                                    data = data.Remove(0, data.IndexOf(":")+1);
                                                    SystemInfo.dt = data;
                                                   
                                                }
                                                else
                                                {
                                                    int c = Convert.ToInt32(data.Substring(0, data.IndexOf(":")));
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    switch (c)
                                                    {



                                                        case 0:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);
                                                               // MessageBox.Show(data);
                                                                callObjects.scan.label2.Text = data.Substring(0, data.IndexOf(":"));
                                                                //  MessageBox.Show(data);
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                              //  MessageBox.Show(data);
                                                                callObjects.scan.label3.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                              //  MessageBox.Show(data);
                                                                callObjects.scan.label4.Text = data.Substring(0, data.Length);

                                                                callObjects.scan.panel1.Visible = true;

                                                                break;
                                                            }
                                                        case 1:
                                                            {
                                                                //  data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label7.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label6.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label5.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel2.Visible = true;
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label10.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label9.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label8.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel3.Visible = true;
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label13.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label12.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label11.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel4.Visible = true;
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label16.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label15.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label14.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel5.Visible = true;
                                                                break;
                                                            }
                                                        case 5:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label19.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label18.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label17.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel6.Visible = true;
                                                                break;
                                                            }
                                                        case 6:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label22.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label21.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label20.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel7.Visible = true;
                                                                break;
                                                            }
                                                        case 7:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label25.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label24.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label23.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel8.Visible = true;
                                                                break;
                                                            }
                                                        case 8:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label28.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label27.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label26.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel9.Visible = true;
                                                                break;
                                                            }
                                                        case 9:
                                                            {
                                                                // data = data.Remove(0, data.IndexOf(":") + 1);

                                                                callObjects.scan.label31.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label30.Text = data.Substring(0, data.IndexOf(":"));
                                                                data = data.Remove(0, data.IndexOf(":") + 1);
                                                                callObjects.scan.label29.Text = data.Substring(0, data.Length);
                                                                callObjects.scan.panel10.Visible = true;
                                                                break;
                                                            }
                                                    }
                                                }
                                                break;
                                            }
                                        case "108":
                                            {
                                                if(data.Contains("ser"))
                                                {
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    SystemInfo.mod = data;

                                                }
                                                else if (data.Contains("pro"))
                                                {
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    SystemInfo.pro = data;
                                                }
                                                else if (data.Contains("apn"))
                                                {
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    SystemInfo.apn = data;
                                                    APN.DataApn = data;
                                                }
                                                else if (data.Contains("dt"))
                                                {
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    SystemInfo.dt = data;
                                                }
                                                else if (data.Contains("wl"))
                                                {
                                                    //MessageBox.Show(data);
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    SystemInfo.wl = data+"meters";
                                                }
                                                else if (data.Contains("li"))
                                                {
                                                   // MessageBox.Show(data);
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                   
                                                   callObjects.sys.lblLogInterval.Text = data+" mins";
                                                 //  MessageBox.Show(callObjects.sys.lblLogInterval.Text);
                                                }
                                                else if (data.Contains("bat"))
                                                {
                                                    // MessageBox.Show(data);
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    callObjects.sys.lblBattery.Text = data;
                                                }
                                                break;
                                            }

                                        case "110":
                                            {

                                                // MessageBox.Show("1"+data);

                                                if (data.Contains("apn"))
                                                {

                                                    data = data.Remove(0, 4);
                                                    //   MessageBox.Show(data);
                                                    APN apn = new APN();
                                                    //    apn.textBox1.Text = data;
                                                    APN.DataApn = data;
                                                    callObjects.apn.textBox1.Text = data;
                                                }
                                                if (data.Contains("err"))
                                                {
                                                    data = data.Remove(0, data.LastIndexOf(':') + 1);
                                                    callObjects.apn.bunifuiOSSwitch1.Enabled = true;
                                                    callObjects.apn.pictureBox1.Visible = false;

                                                    callObjects.apn.pictureBox3.Visible = false;
                                                    callObjects.apn.btn_SendData.Enabled = true;
                                                    callObjects.apn.bunifuiOSSwitch1.Enabled = true;
                                                    MB_message mb = new MB_message();
                                                    mb.Theme_error(data.ToUpper());
                                                    mb.Show();


                                                }
                                                if (data.Contains("suc"))
                                                {
                                                    data = data.Remove(0, data.LastIndexOf(':') + 1);

                                                    callObjects.apn.pictureBox3.Visible = false;
                                                    callObjects.apn.btn_SendData.Enabled = true;
                                                    callObjects.apn.bunifuiOSSwitch1.Enabled = true;
                                                    MB_message mb = new MB_message();
                                                    mb.Theme_success(data.ToUpper());
                                                    mb.Show();

                                                }
                                                APN.DataRec = data;
                                                break;
                                            }
                                        case "111":
                                            {
                                                if (data.Contains("apn"))
                                                {

                                                    data = data.Remove(0, 4);
                                                    //   MessageBox.Show(data);
                                                    APN apn = new APN();
                                                    //    apn.textBox1.Text = data;
                                                    APN.DataApn = data;
                                                    callObjects.setup.tb_apn.Text = data;
                                                }
                                                else if(data.Contains("log_array"))
                                                {
                                                     //data = data.Remove(0, data.LastIndexOf(":")+1);

                                                     //string[] _log = new string[20];
                                                     //_log = data.Split(',');
                                                     //MessageBox.Show(_log[0]);
                                                     //callObjects.setup.NUD_LogInterval.Items.Clear();
                                                     //for (int i = 0; i < 20; i++)
                                                     //{
                                                     //    if (_log[i] != "")
                                                     //    {
                                                     //        callObjects.setup.NUD_LogInterval.Items.Add(_log[i]);
                                                     //    }
                                                     //}
                                                     
                                                }
                                                

                                                break;
                                            }
                                        case "112":
                                            {
                                               
                                                if(data.Contains("ftp"))
                                                {
                                                   // MessageBox.Show(data);
                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    APN.ftp_username = data.Substring(0, data.IndexOf(":"));

                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    APN.ftp_password = data.Substring(0, data.IndexOf(":"));

                                                    data = data.Remove(0, data.IndexOf(":") + 1);
                                                    APN.ftp_host = data;

                                                }
                                                break;
                                            }


                                    }
                                }
                            }
                            catch(TimeoutException ex)
                            {
                                MB_message mb = new MB_message();
                                mb.Theme_error(ex.Message);
                                mb.Show();
                               // MessageBox.Show(ex.Message);
                            }
                           //------

                        }
                        ));



                   


                }
                else
                {

                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }



        }

        private void port_ErrorRecieved(object sender, SerialErrorReceivedEventArgs arg)
        {
            //Code on Error Data
        }
        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                serialPort.WriteLine("$3:");                            //Ask for the count
            }
            catch (Exception ex)
            {
                //serialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);
                //serialPort.ErrorReceived -= new SerialErrorReceivedEventHandler(port_ErrorRecieved);
                //   _timer.Enabled = false;
                //   MessageBox.Show("Device Disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  btn_connect.Text = "Connect";
                //foreach (Control ctl in tabConnect.Controls) ctl.Enabled = false;
                //((Control)this.tabConnect).Enabled = true;
                cboPorts.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            clickcount++;
           // MessageBox.Show(clickcount + " ");
            if (clickcount > 4)
            {
                panel1.Visible = true;
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // MessageBox.Show("h");
            try
            {
                SerialPortCommunicator.SerialPort.WriteLine("$107:");
               // SerialPortCommunicator.SerialPort.WriteLine("wake");

            }
            catch (Exception e1)
            {
              //  

                // MessageBox.Show("disconnected");
                SerialPortCommunicator.SerialPort.Dispose();
                SerialPortCommunicator.SerialPort.Close();
                timer1.Enabled = false;
                timer1.Stop();
                lbl_connecting.Visible = false;

                SerialPortCommunicator.SerialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);
                btn_connect2.Text = "Connect";
                btn_connect2.EnabledBGColor = Color.SeaGreen;
                Form1.light = false;

                cboPorts.Enabled = true;
                cboPorts.Items.Clear();

                validate = false;
              //  MessageBoxIcon mi = MessageBoxIcon.Information;
                string data= "Device not Found, closing the Application";
             //   MessageBox.Show(data , "Info" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                MB_message mb = new MB_message();
                //mb.BackColor = Color.FromArgb(255, 231,147);
                //mb.label1.Text = "Device not Found, closing the Application";
                //mb.label1.Font = new Font("Century Gothic", 10);
                //mb.label1.ForeColor = Color.Black;
                //mb.label2.ForeColor = Color.Black;
                //mb.label2.Text = "i";
                //mb.label2.Font = new Font("Webdings",36);
                mb.Theme_error(data);
                mb.Show();

              //  System.Threading.Thread.Sleep(1000);
                
                Application.Exit();

               // timer_port.Enabled = false;
               // btn_connect.Enabled = false;
                
                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //trial_ss t = new trial_ss();
            //t.Show();
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                timer_port.Enabled = true;
                selectedPort = cboPorts.SelectedItem.ToString();
                // MessageBox.Show(cboPorts.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
            }

        }

        private void timer_port_Tick(object sender, EventArgs e)
        {
            
            bool notAvail = false;
            string[] items1 = new String[30];
            int index = 0;
            try
            {
                cboPorts.Items.Clear();
                foreach (String port in SerialPort.GetPortNames())
                {

                    //if (validPort != null && port != validPort)
                    //{
                    //    notAvail = true;
                    //}
                    //else
                    //{
                    //    notAvail = false;
                    //}

                    items1[index] = port;

                    //if (!cboPorts.Items.Contains(port) && validate==true)
                    if (!cboPorts.Items.Contains(port))
                    {
                      
                        cboPorts.Items.Add(port);
                        if (cboPorts.Items.Contains(selectedPort))
                        {
                            cboPorts.SelectedItem = selectedPort;
                        }
                        else
                        {
                          //   cboPorts.SelectedIndex = 0;
                        }
                        cboPorts.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                   // MessageBox.Show(cboPorts.Items.Count.ToString());
                   
                    index++;

                }

                if (cboPorts.Items.Count == 0)
                {
                    btn_connect2.Enabled = false;
                }
                else
                {
                    btn_connect2.Enabled = true;
                }

                //for (int i = 0; i < items1.Length; i++)
                //{
                //    cboPorts.SelectedIndex=i;
                //    MessageBox.Show(cboPorts.SelectedItem.ToString());
                //    if (items1[i] == cboPorts.SelectedItem)
                //    {

                //    }
                //}
                // 

                //if (notAvail == true)
                //{
                //  //  cboPorts.Items.Remove(validPort);
                //    MessageBox.Show("disconnected");
                //    //SerialPortCommunicator.SerialPort.Dispose();
                //    //SerialPortCommunicator.SerialPort.Close();
                //    //timer1.Enabled = false;
                //    //timer1.Stop();
                //    //lbl_connecting.Visible = false;
                //    //SerialPortCommunicator.SerialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);
                //}


            }
            catch (Exception ex)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Connect_KeyDown(object sender, KeyEventArgs e)
        {
         //  MessageBox.Show("YES");
            //if (e.KeyCode == Keys.T)
            //{
            //    panel1.Visible = true;
            //}
        }

        private void Connect_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("press");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(connecting==true)
            {
               

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             if (InvokeRequired)
                {
                        this.Invoke(new MethodInvoker(delegate
                        {
            
            //btn_connect.BackColor = Color.DodgerBlue;
         //   lbl_connecting.Visible = true;

            if (btn_connect2.Text == "Connect")                      // when the software is not connected to the device then the button text is connect
            {



                if (!SerialPortCommunicator.SerialPort.IsOpen)
                {
                    try
                    {
                        portName = Convert.ToString(cboPorts.SelectedItem);    // this saves the values of selected port in 'portName' variable
                        lbl_connecting.Visible = true;
                        Connect con = new Connect();
                        con.UseWaitCursor = true;
                        // following commands used to configure the serial  port communicator. 
                        SerialPortCommunicator.SerialPort.BaudRate = Convert.ToInt32(tb_BaudRate.Text);
                        SerialPortCommunicator.SerialPort.PortName = Convert.ToString(cboPorts.SelectedItem);
                        SerialPortCommunicator.SerialPort.Parity = Parity.None;
                        SerialPortCommunicator.SerialPort.DataBits = 8;
                        SerialPortCommunicator.SerialPort.StopBits = StopBits.One;
                        SerialPortCommunicator.SerialPort.RtsEnable = true;
                        SerialPortCommunicator.SerialPort.Handshake = Handshake.None;
                        SerialPortCommunicator.SerialPort.Open();
                        //  SerialPortCommunicator.SerialPort.WriteLine("start");
                        System.Threading.Thread.Sleep(40);
                        SerialPortCommunicator.SerialPort.WriteLine("$101:wake");           // this sends the wake to the device program just to begin the connection
                        System.Threading.Thread.Sleep(10);
                        SerialPortCommunicator.SerialPort.WriteLine("$101:Start$");
                        SerialPortCommunicator.SerialPort.DiscardOutBuffer();
                        SerialPortCommunicator.SerialPort.DiscardInBuffer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    try
                    {
                        // when device program recieves the wake & start then it gives the response back to the software as "$softwareVersion:$"  (softwareVersion is the variable which holds some value according to the version of the particular arduino program, 
                        SerialPortCommunicator.SerialPort.ReadTimeout = Convert.ToInt32(tb_readTimeout.Text);
                        if (SerialPortCommunicator.SerialPort.IsOpen)
                        {

                            s = SerialPortCommunicator.SerialPort.ReadTo(":$");
                           
                            //  MessageBox.Show(s);

                            if (s.Contains("$"))                    // if the response which comes from the device contains the "$" then the software connects with the device
                            {
                              
                                if (s.Contains("$open_msg"))
                                {
                                  
                                    ww.Show();
                                    
                                }
                               

                                MB_message mb = new MB_message();

                                mb.Theme_success("Connected Successfully");
                                mb.Show();
                                // s = SerialPortCommunicator.SerialPort.ReadTo(":$");
                                if (s.Contains("set_log"))
                                {
                                    //    MessageBox.Show("yes");
                                    Form1 f = new Form1();

                                    Form1.setlog = true;


                                    Form1.setup_com = true;
                                    Setup.setup_com = true;

                                }
                                else if (s.Contains("full"))
                                {
                                    Form1.all = true;
                                }
                                else if (s.Contains("not_ftp"))
                                {
                                    Form1.notftp = true;
                                }
                                _timer = new System.Timers.Timer();
                                _timer.Interval = 4000;
                                // _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
                                _timer.Enabled = true;
                                btn_connect2.Text = "Disconnect";
                                btn_connect2.EnabledBGColor = Color.Crimson;
                                cboPorts.Enabled = false;

                                lbl_connecting.Visible = false;
                                UseWaitCursor = false;

                                //Form1 f1 = new Form1();
                                //f1.Constatus = true;

                                
                                Form1.light = true;

                                SerialPortCommunicator.SerialPort.WriteLine("$3:$");
                                SerialPortCommunicator.SerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);
                                SerialPortCommunicator.SerialPort.ErrorReceived += new SerialErrorReceivedEventHandler(port_ErrorRecieved);



                                //Code to retrieve the value of the previous rain from the database


                                BackUpData BUD = new BackUpData();
                                BUD.passvalue = (cboPorts.SelectedItem.ToString());
                                // MessageBox.Show(cboPorts.SelectedItem.ToString());

                                timer1.Enabled = true;
                                timer1.Start();
                            }
                            //else
                            //{
                            //    MessageBox.Show("Wrong Port Selected", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //    //SerialPortCommunicator.SerialPort.WriteLine("$$$");
                            //    serialPort.Dispose();


                            //    serialPort.Close();
                            //}
                        }
                    }
                    catch (TimeoutException ex)
                    {
                        //MessageBox.Show("Device Not Found");

                        MB_message mb = new MB_message();
                        mb.Theme_error("Sorry! Device Not Found");
                        mb.Show();
                        // SerialPortCommunicator.SerialPort.WriteLine("$102:disconnect");
                        SerialPortCommunicator.SerialPort.Dispose();
                        SerialPortCommunicator.SerialPort.Close();
                        timer1.Enabled = false;
                        timer1.Stop();
                        lbl_connecting.Visible = false;
                        SerialPortCommunicator.SerialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);

                    }
                    //--------
                }
                else
                {
                    //MessageBox.Show("Port Already Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SerialPortCommunicator.SerialPort.WriteLine("$110:TurnOff");
                    SerialPortCommunicator.SerialPort.WriteLine("$102:disconnect");

                  
                    SerialPortCommunicator.SerialPort.Dispose();
                    SerialPortCommunicator.SerialPort.Close();
                    timer1.Enabled = false;
                    timer1.Stop();
                    lbl_connecting.Visible = false;
                    SerialPortCommunicator.SerialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);

                }
            }
            else
            {
                if (SerialPortCommunicator.SerialPort.IsOpen)
                {
                    //serialPort.WriteLine("$2:");
                    SerialPortCommunicator.SerialPort.WriteLine("$110:TurnOff");
                    SerialPortCommunicator.SerialPort.WriteLine("$102:disconnect");
                    SerialPortCommunicator.SerialPort.Dispose();
                    SerialPortCommunicator.SerialPort.Close();
                    timer1.Enabled = false;
                    timer1.Stop();
                    lbl_connecting.Visible = false;
                    SerialPortCommunicator.SerialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);


                }
                btn_connect2.Text = "Connect";
                btn_connect2.EnabledBGColor = Color.SeaGreen;
                Form1.light = false;

                cboPorts.Enabled = true;
            }
                        }
                        ));






                }
             else
             {

             }

        }
    }
}
