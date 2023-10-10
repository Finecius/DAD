using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03_Exercício01
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox1.Text);
            int i = 0;
            do
            {
                
                listBox1.Items.Add(c + " * " +i+" = "+c*i);
                i++;
            } while (i <= 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox1.Text);
            int i = 0;
            while (i <= 10)
            {
                listBox1.Items.Add(c + " * " + i + " = " + c * i);
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox1.Text);

            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(c + " * " + i + " = " + c * i);
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                button2.Focus();
        }
    }
}
