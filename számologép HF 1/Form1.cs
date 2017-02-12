using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace számologép_HF_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            ???= 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (???=0)
                textBox1.Text = 0;
        }
    }
}
