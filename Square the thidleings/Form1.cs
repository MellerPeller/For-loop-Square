using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_the_thidleings
{
    public partial class Form1 : Form
    {
      int number1 = 0;
        int number2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);
            int hold;

            for (int.Parse(textBox1.Text); number1 < number2 + 1; number1++) 
            {
                hold = number1 * number1;
                textBox3.Text = textBox3.Text + " " +hold.ToString();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
