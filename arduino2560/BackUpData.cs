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
    public partial class BackUpData : Form
    {
        delegate void SetTextCallback(string text);
        delegate void SetTextRainCallback(string text);
        String s = "";
        String Msg = "";
        System.Timers.Timer _timer;
        int startposition = 5;
        int endposition = 0;

        string[] fileNames = new string[100];
        int fileIndex = 0;
        bool check = false;

        int dataRecieveCount = 0;
        int click = 1;

        bool dataStatus = false;
        string fileData;

        public static int SF_Count = 0;
        public static int intervals;
        string[] selectedFiles = new string[100];
       public static int n = 0;

       public static int progress;
       public static bool lblCopy=true;
        public static string DataRec;
        public static String Filename, Filedata,terminate,end;
        int bt_SelectAll_check = 1;
        public Bitmap bmp;

       // Form1 ths;

        private string Nm;

        public string passvalue
        {
            get
            {
                return Nm;
            }
            set
            {
               // MessageBox.Show(value);
                Nm = value;
            }
        }

        public BackUpData()
        {
           // System.Threading.Thread.Sleep(50);
            InitializeComponent();
          //  ths = frm;

         //   MessageBox.Show("@"+Convert.ToString(Nm));

           

        }

     

        private void BackUpData_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            try
            {
               // pictureBox1.Image = arduino2560.Properties.Resources.sp_1;
                //bmp = (Bitmap)Bitmap.FromFile(arduino2560.Properties.Resources.spinner_2.ToString());
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox1.Image = bmp;

                

                lbl_CopyingFiles.Visible = false;
                //timer1.Enabled = true;
                //timer1.Start();
                Form1.backupDataLoad = true;
                if (!SerialPortCommunicator.SerialPort.IsOpen)
                {

                    SerialPortCommunicator.SerialPort.BaudRate = 9600;
                    // messagebox.show(nm);
                    //   SerialPortCommunicator.SerialPort.portname = convert.tostring("com8");
                    SerialPortCommunicator.SerialPort.PortName = Connect.portName;
                    SerialPortCommunicator.SerialPort.Open();
                    // SerialPortCommunicator.SerialPort.writeline("$101:start$");
                    SerialPortCommunicator.SerialPort.DiscardOutBuffer();
                    SerialPortCommunicator.SerialPort.DiscardInBuffer();
                }
                SerialPortCommunicator.SerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);
                SerialPortCommunicator.SerialPort.ErrorReceived += new SerialErrorReceivedEventHandler(port_ErrorRecieved);
                


                SerialPortCommunicator.SerialPort.WriteLine("$103:");
                // listBox1.Visible = true;

                // String s=(SerialPortCommunicator.SerialPort.ReadLine());

                if (s.Contains("#!"))
                {
                    //   MessageBox.Show("Enter");
                    lbl_MissingError.Text = "SD is Missing, Corrupted!";

                }
            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show(); 
            }
            
        }
        void port_DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {

                //if (SerialPortCommunicator.SerialPort.ReadLine().Contains("@103"))
                //{
                //     s = SerialPortCommunicator.SerialPort.ReadLine();
                //     MessageBox.Show("Hai");
                //}
                //  MessageBox.Show(s);

                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        //  MessageBox.Show(s);

                        if (DataRec != null && DataRec.Contains('@'))
                        {
                            //  MessageBox.Show("Enter");

                            // MessageBox.Show(DataRec);
                            DataRec = DataRec.Remove(0, 1);
                          //  MessageBox.Show(DataRec.ToString());
                            if (!DataRec.Contains("ftpfile.csv") && (DataRec.Contains(".csv")) || (DataRec.Contains(".CSV")))
                            {
                                CheckBox cb = new CheckBox();
                                cb = addCheckbox(dataRecieveCount, startposition, endposition);
                                cb.CheckedChanged += new System.EventHandler(this.cb_filesCheckChange);


                                pnl_FileList.Controls.Add(cb);




                                endposition += 20;

                                //fileNames[fileIndex] = s;

                                //  MessageBox.Show(s);

                                dataRecieveCount++;
                                label1.Text = dataRecieveCount.ToString();
                                //fileIndex++;
                                

                            }
                            //    System.Threading.Thread.Sleep(5);

                        }



                        bunifuProgressBar1.Value = progress;

                     //   System.Threading.Thread.Sleep(100);

                        //if (lblCopy == false)
                        //{
                        //   // MessageBox.Show(lbl_CopyingFiles.Visible.ToString());
                           
                        //   lbl_CopyingFiles.Visible = false;
                        //}
                         
                        //if (s.Contains("@99:"))
                        //{
                        //    while (true)
                        //    {
                        //        //  MessageBox.Show("enter");
                        //        string directoryName = @"C:\Next-Comm";

                        //        if (!System.IO.File.Exists(directoryName))
                        //        {
                        //            System.IO.Directory.CreateDirectory(directoryName);
                        //        }
                        //        // MessageBox.Show(selectedFiles[n] + "@");



                        //        //   fileData = SerialPortCommunicator.SerialPort.ReadLine();
                        //        //    MessageBox.Show(fileData.ToString());
                        //        if (terminate.Contains("terminate"))
                        //        {

                        //            // MessageBox.Show("Data Copied Successfully");
                        //            // lbl_Data_Copied.Visible = true;
                        //            MB_message mb = new MB_message();
                        //            mb.label1.Text = "Data Copied Successfully!";
                        //            mb.Show();
                        //            lbl_CopyingFiles.Visible = false;
                        //            //pb_loading.Visible = false;
                        //            // bunifuFlatButton1.Visible = true;
                        //            bunifuProgressBar1.Value = 100;
                        //            //  progressBar1.Visible = false;
                        //            // MessageBox.Show("Data Copied Successfully");
                        //            //lbl_filesCopied.Text += SF_Count;
                        //            break;
                        //        }
                        //        //  MessageBox.Show(fileData.ToString());
                        //        string fileName = Filename;
                        //        //   fileName = fileName.Remove(fileName.Length - 1, 1);
                        //        //   //fileData = "";

                        //        ////   MessageBox.Show(fileName + "@");
                        //        //   fileName = fileName.Remove(fileName.Length - 1, 1);
                        //        StreamWriter fileWriter = new StreamWriter(directoryName + @"\" + fileName);
                        //        while (true)
                        //        {


                        //            // SerialPortCommunicator.SerialPort.ReadTimeout = 15000;
                        //            //  fileData = SerialPortCommunicator.SerialPort.ReadLine();


                        //            if (end.Contains("?+end"))
                        //            {
                        //                // MessageBox.Show(SF_Count.ToString());
                        //                bunifuProgressBar1.Value += intervals;
                        //                SF_Count = 0;
                        //                break;
                        //            }
                        //            //  richTextBox1.Text += fileData;
                        //            fileWriter.Write(Filedata);

                        //        }
                        //        fileWriter.Close();
                        //        n++;
                        //    }
                        //}
                    }
                    ));

                }
                else
                {

                    //if (s.IndexOf('@') == 0)
                    //{
                    //    dataRecieveCount++;
                    //    s = s.Remove(0, 1);


                    //    CheckBox cb = addCheckbox(dataRecieveCount, startposition, endposition);
                    //    cb.CheckedChanged += new System.EventHandler(this.cb_filesCheckChange);


                    //    pnl_FileList.Controls.Add(cb);




                    //    endposition += 20;

                    //    //fileNames[fileIndex] = s;

                    // //   MessageBox.Show(s);
                    //    //fileIndex++;

                    //}
                    //if (s.Contains("$99:"))
                    //{


                    //    while (true)
                    //    {
                    //        // MessageBox.Show("enter");


                    //        string directoryName = @"C:\Next-Comm";
                    //        if (!System.IO.File.Exists(directoryName))
                    //        {
                    //            System.IO.Directory.CreateDirectory(directoryName);

                    //        }
                    //        // MessageBox.Show(selectedFiles[n] + "@");
                    //        fileData = SerialPortCommunicator.SerialPort.ReadLine();
                    //        if (fileData.Contains("@terminate"))
                    //        {

                    //            break;
                    //            // MessageBox.Show("Data Copied Successfully");

                    //        }

                    //        string fileName = Filename;
                    //        //fileName = fileName.Remove(fileName.Length - 1, 1);



                    //        //fileData = "";

                    //        ////  MessageBox.Show(fileName+"@");
                    //        //fileName = fileName.Remove(fileName.Length - 1, 1);
                    //        StreamWriter fileWriter = new StreamWriter(directoryName + @"\" + fileName);
                    //        while (true)
                    //        {

                    //            //fileData = SerialPortCommunicator.SerialPort.ReadLine();
                    //            if (FileData.Contains("?+end"))
                    //            {
                    //                break;
                    //            }


                    //           // richTextBox1.Text += fileData;
                    //            fileWriter.Write(fileData);


                    //        }
                    //        fileWriter.Close();
                    //        n++;
                    //    }
                    //  //  lbl_No_of_files.Text += dataRecieveCount.ToString();
                    //}
                }
                // 
            }
            catch (TimeoutException t)
            {

            }

        }
        CheckBox addCheckbox(int i, int start, int end)
        {
            CheckBox cb = new CheckBox();
            cb.Name = "files" + i.ToString();
            cb.Text = DataRec;
            cb.Font = new Font("Century Gothic", 12);
            cb.Location = new Point(start, end);
            cb.TextAlign = ContentAlignment.MiddleCenter;
            cb.Margin = new Padding(5);
            cb.AutoSize = true;
            cb.BackColor = Color.Transparent;
            //  cb.CheckAlign = ContentAlignment.MiddleRight;
            return cb;
        
        }


       

        void port_ErrorRecieved(object sender, SerialErrorReceivedEventArgs e)
        {

        }

        void cb_filesCheckChange(object sender, EventArgs e)
        {

            bt_BackUp.Enabled = true;
            bt_delete.Enabled = true;
            //CheckBox currentcheckbox = (CheckBox)sender;
            //if (currentcheckbox.Checked == false)
            //{
            //  //  cb_SelectAll.Checked = false;
            //}
            // currentcheckbox.Checked = true;

        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$103:");
            // MessageBox.Show(s);
            bt_BackUp.Visible = true;
            pnl_FileList.Visible = true;
            // listBox1.Visible = true;
        }

        private void cb_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //if (cb_SelectAll.Checked == true)
            //{
            //    for (int i = 0; i <= dataRecieveCount; i++)
            //    {

            //        Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

            //        foreach (var item in Controls)
            //        {
            //            CheckBox check = item as CheckBox;
            //            check.Checked = true;
            //        }

            //    }
            //}
            //else
            //{
            //    for (int i = 0; i <= dataRecieveCount; i++)
            //    {

            //        Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

            //        foreach (var item in Controls)
            //        {
            //            CheckBox check = item as CheckBox;
            //            check.Checked = false;
            //        }
            //    }
            //}
        }

        private void bt_BackUp_Click(object sender, EventArgs e)
        {
            progress = 0;
          //  lbl_Data_Copied.Visible = false;
            bunifuProgressBar1.Visible = true;
            bunifuProgressBar1.Value = 0;


           
            
           // pb_loading.Visible = true;
           // MessageBox.Show(SF_Count.ToString());
           
            try
            {

                callObjects.con.timer1.Stop();
                for (int i = 0; i <= dataRecieveCount; i++)
                {

                    Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

                    foreach (var item in Controls)
                    {

                        CheckBox check = item as CheckBox;
                        if (check.Checked == true)
                        {

                            //  check.Text = check.Text.Remove(0, 4);
                            //  selectedFiles[i] =check.Text;
                            //   lbl_Title.Text += "?" + (i).ToString() + "*";
                            // listBox1.Items.Add(check.Text);
                            bt_BackUp.Enabled = true;
                            SerialPortCommunicator.SerialPort.WriteLine("$105:" + check.Text);

                            //  MessageBox.Show(selectedFiles[i]);
                            //  MessageBox.Show(fileNames[i]);

                            //for (int k = 0; k < 10000; k++)
                            //{
                            //    Console.WriteLine(i);
                            //}

                            // int milliseconds = 2000;
                            // Thread.Sleep(milliseconds);
                            System.Threading.Thread.Sleep(40);
                            SF_Count++;
                        }

                        // SerialPortCommunicator.SerialPort.WriteLine("$104:@Terminate");

                    }

                }
                lbl_remainging.Text = SF_Count.ToString();
                //label2.Text = label2.Text.Insert(5, SF_Count.ToString());
                // label2.Text += "#";

                //for (int i = 0; i < SF_Count; i++)
                //{
                SerialPortCommunicator.SerialPort.WriteLine("$104:" + SF_Count.ToString());
                intervals = 100 / SF_Count;
                // SF_Count = 0;
                //}

                // SerialPortCommunicator.SerialPort.WriteLine(label2.Text);


                callObjects.bud.lbl_filename.Visible = true;
                //callObjects.bud.lbl_filename.Text = "| Filename: " + filename;
                callObjects.bud.label4.Visible = true;
                lbl_copied_count.Visible = true;
                callObjects.bud.label3.Visible = true;
                callObjects.bud.lbl_remainging.Visible = true;
                lbl_wait.Visible = true;
                lbl_CopyingFiles.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select the file first");
            }

        }

        private void bt_SelectAll_Click(object sender, EventArgs e)
        {
            bt_SelectAll_check++;
            if (bt_SelectAll_check % 2 == 0)
            {
              //  bt_SelectAll.Text = "✔";
                for (int i = 0; i <= dataRecieveCount; i++)
                {

                    Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

                    foreach (var item in Controls)
                    {
                        CheckBox check = item as CheckBox;
                        check.Checked = true;
                    }

                }
            }
            else
            {
             //   bt_SelectAll.Text = "🔳";
                for (int i = 0; i <= dataRecieveCount; i++)
                {

                    Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

                    foreach (var item in Controls)
                    {
                        CheckBox check = item as CheckBox;
                        check.Checked = false;
                    }
                }
            }
        }

        private void bt_SelectAll_Click_1(object sender, EventArgs e)
        {
            bt_SelectAll_check++;
            System.Threading.Thread.Sleep(10);
            if (bt_SelectAll_check % 2 == 0)
            {
                bt_SelectAll.Text = "✔";
                for (int i = 0; i <= dataRecieveCount; i++)
                {

                    Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

                    foreach (var item in Controls)
                    {
                        CheckBox check = item as CheckBox;
                        check.Checked = true;
                    }

                }
            }
            else
            {
                bt_SelectAll.Text = "🔳";
                for (int i = 0; i <= dataRecieveCount; i++)
                {

                    Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

                    foreach (var item in Controls)
                    {
                        CheckBox check = item as CheckBox;
                        check.Checked = false;
                    }                                                                    
                }
            }
        }

        private void bt_getData_Click(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$103:");
        }

        private void bt_getData_Click_1(object sender, EventArgs e)
        {
            SerialPortCommunicator.SerialPort.WriteLine("$103:");
            // MessageBox.Show(s);
            bt_BackUp.Visible = true;
            pnl_FileList.Visible = true;
        }

        private void lbl_MissingError_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // MessageBox.Show("h");
            SerialPortCommunicator.SerialPort.WriteLine("wake");
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Remove the Selected files?", "Confirm?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                for (int i = 0; i <= dataRecieveCount; i++)
                {

                    Control[] Controls = pnl_FileList.Controls.Find("files" + i.ToString(), false);

                    foreach (var item in Controls)
                    {

                        CheckBox check = item as CheckBox;
                        if (check.Checked == true)
                        {

                            SerialPortCommunicator.SerialPort.WriteLine("$109:" + check.Text);

                            //lbl_CopyingFiles.Text="Deleting "+check.Text;
                            //lbl_CopyingFiles.Visible = true;
                            System.Threading.Thread.Sleep(40);
                            SF_Count++;


                        }


                    }

                }
                SerialPortCommunicator.SerialPort.WriteLine("$109:@");

                MB_message mb = new MB_message();
                mb.label1.Text = "Deleted Successfully";
                mb.Show();

                pnl_FileList.Controls.Clear();
                //  SerialPortCommunicator.SerialPort.WriteLine("$103:");
                endposition = 0;
                dataRecieveCount = 0;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                endposition = 0;
                dataRecieveCount = 0;
                pnl_FileList.Controls.Clear();
                pnl_FileList.Controls.Add(pictureBox4);
                bt_SelectAll.Text = "🔳";
                SerialPortCommunicator.SerialPort.WriteLine("$103:");
            }
            catch (Exception ex)
            {
                MB_message mb = new MB_message();
                mb.Theme_error(ex.Message);
                mb.Show();
            }
        }

    }
}
