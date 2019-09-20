using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) &&
              !string.IsNullOrEmpty(textBox2.Text))
                {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Calculation cl = new Calculation(a, b);
                label1.Text = cl.execute("+").ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
              !string.IsNullOrEmpty(textBox2.Text))
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Calculation cl = new Calculation(a, b);
                label1.Text = cl.execute("/").ToString();
            }
        }
    }
}
