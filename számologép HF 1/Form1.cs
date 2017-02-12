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
        float num1;


        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && textBox1.TextLength > 0)
            {
                num1 = 0; textBox1.Clear();
            }
            else if (num1 > 0 && textBox1.TextLength > 0)
            {
                textBox1.Clear();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_egyenlo_Click(object sender, EventArgs e)
        {

        }
        private void button_osztas_Click(object sender, EventArgs e)
        {

        }

        private void button_szorzas_Click(object sender, EventArgs e)
        {

        }

        private void button_kivonas_Click(object sender, EventArgs e)
        {

        }

        private void button_oszeadas_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }




    }
}
