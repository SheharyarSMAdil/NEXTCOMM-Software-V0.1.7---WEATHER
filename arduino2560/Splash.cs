using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace arduino2560
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            lbl_NC_version.Text += Application.ProductVersion;
            refresh();
            this.Enabled = false;
            timer1.Start();
            timer1.Enabled = true;
            if (pictureBox2.Visible == false)
            {
                bunifuTransition1.ShowSync(pictureBox2);
                bunifuTransition2.ShowSync(lbl_NC_version);
            }
        }
        private void refresh()
        {
            try
            {

                base.Hide();
                Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(base.Location.X, base.Location.Y, 0, 0, base.Size, CopyPixelOperation.SourceCopy);


                string outputFileName = "spls.bin";
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
                    {
                        bitmap.Save(memory, ImageFormat.Png);
                        byte[] bytes = memory.ToArray();
                        fs.Write(bytes, 0, bytes.Length);

                    }
                }




               

                this.BackgroundImage = bitmap;
                base.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (count < 500)
            {
                count++;
                bunifuProgressBar1.Value = count / 5;
                if (count == 100)
                {
                    bunifuCustomLabel1.Text = "Checking for Updates..";
                }
                else if (count == 200)
                {
                    bunifuCustomLabel1.Text = "Initialising Serial Communication..";
                }
                else if (count == 300)
                {
                    bunifuCustomLabel1.Text = "Initialising Packages..";
                }
                else if (count == 400)
                {
                    bunifuCustomLabel1.Text = "Initialising NST Modules..";
                }
                else if (count == 480)
                {
                    bunifuCustomLabel1.Text = "Starting Next-Comm...";
                }

                // refresh();
            }
            else
            {
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
        }
    }
}
