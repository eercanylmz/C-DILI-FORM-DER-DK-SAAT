using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_DILI_FORM_DER_DK_SAAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            int hour, mınute;
            number = Convert.ToInt32(textBox1.Text);
            hour = number / 60;
            label4.Text = hour.ToString();
            mınute = number % 60;
            label2.Text = mınute.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
