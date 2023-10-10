using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03_Exercício02
{
    public partial class Form1 : Form
    {
        int op = 0;
        double r = 0, n1 = 0;
        Boolean C;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";


        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                op = 2;
                n1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                r = r + n1;
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            C=true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (op == 1)
                {

                    r = n1 + double.Parse(textBox1.Text);
                    textBox1.Text = r.ToString();
                    C = false;
                    if (C == true)
                    {
                        r = 0;
                        n1 = 0;
                        op = -1;

                    }



                }

                if (op == 2)
                {
                    r = n1 - double.Parse(textBox1.Text);
                    textBox1.Text = r.ToString();
                    C = false;
                    if (C == true)
                    {
                        r = 0;
                        n1 = 0;
                        op = -1;

                    }
                }
                if (op == 3)
                {
                    if (double.Parse(textBox1.Text) != 0)
                    {
                        r = n1 / double.Parse(textBox1.Text);
                        textBox1.Text = r.ToString();
                        C = false;
                        if (C == true)
                        {
                           
                            op = -1;

                        }
                    }
                  
                }
                if (op == 4)
                {
                    r = n1 * double.Parse(textBox1.Text);
                    textBox1.Text = r.ToString();
                    C = false;
                    if (C == true)
                    {
                       
                        op = -1;

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                op = 1;
                n1 = double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            r = r + n1;
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(",")))
            {   if (String.IsNullOrEmpty(textBox1.Text))
                    textBox1.Text = textBox1.Text + "0,";
            else
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                op = 3;
                n1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                r = r + n1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                op = 4;
                n1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                r = r + n1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
    }
}
