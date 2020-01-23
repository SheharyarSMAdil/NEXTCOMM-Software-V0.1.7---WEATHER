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
    public partial class MB_message : Form
    {
        int timerTick = 0;
        public MB_message()
        {
            InitializeComponent();
         //   this.Visible = false;
        }

        private void MB_message_Load(object sender, EventArgs e)
        {

           
                int x = Screen.PrimaryScreen.Bounds.Width - 414;
           int y = 30;
           this.Location = new Point(x, y);
           //this.Location.X = x;
           //this.Location.Y = y;



           timer1.Enabled = true;

            timer1.Start();
          


        }

        public  void Theme_error(string content)
        {
            this.Visible = false;
            this.BackColor = Color.Crimson;
            pictureBox1.Image = arduino2560.Properties.Resources.WRONG_animation_126;
            label2.Text = "!";
            label1.Text = content;
            label3.ForeColor = Color.Maroon;
           
            if (content.Length <= 25 )
            {
                label1.Font = new Font("Century Gothic", 16);
            }
            else if (content.Length > 25 && content.Length < 30)
            {
                label1.Font = new Font("Century Gothic", 14);
            }
            else
            {
                label1.Font = new Font("Century Gothic", 12);
            }

        }
        public void Theme_success(string content)
        {
            this.Visible = false;
            this.BackColor = Color.MediumSeaGreen;
            pictureBox1.Image = arduino2560.Properties.Resources.CORECT_animation_126;
            label2.Text = "✔";
            label1.Text = content;
            label3.ForeColor = Color.SeaGreen;
            if (content.Length <= 25)
            {
                label1.Font = new Font("Century Gothic", 16);
            }
            else if (content.Length > 25 && content.Length < 30)
            {
                label1.Font = new Font("Century Gothic", 14);
            }
            else
            {
                label1.Font = new Font("Century Gothic", 12);
            }

        }
        public void Theme_info(string content)
        {
            this.BackColor = Color.LightSeaGreen;
            label2.Text = "📌 ";
            label1.Text = content;
            label3.ForeColor = Color.Teal;
            if (content.Length > 25)
            {
                label1.Font = new Font("Century Gothic", 10);
            }


        }


        private void timer1_Tick(object sender, EventArgs e)
        {

             timerTick++;

             if (timerTick == 5)
             {
                 this.Visible = true;
             }
            if (timerTick == 15)
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
