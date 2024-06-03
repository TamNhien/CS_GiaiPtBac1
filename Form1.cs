using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_GiaiPtBac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            double a, b, x;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);

            if (a != 0)
            {
                x = -b / a;
                lblKQ.Text = "Nghiem cua PT la x = " + x.ToString();
                txtKQ.Text = x.ToString();
            }
            else
            {
                lblKQ.Text = "PT nghiem dung voi moi x";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }
    }
}
