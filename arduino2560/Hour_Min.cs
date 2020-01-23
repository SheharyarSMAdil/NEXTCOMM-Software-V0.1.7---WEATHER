using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino2560
{
    public partial class Hour_Min : NumericUpDown
    {
        public Hour_Min()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        protected override void UpdateEditText()
        {
            this.Text = Value.ToString("00");
            // base.UpdateEditText();
        }
    }
}
