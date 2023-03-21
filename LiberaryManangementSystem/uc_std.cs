using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberaryManangementSystem
{
    public  partial class uc_std : UserControl
    {
        public uc_std()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text == "UserName")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "UserName";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
