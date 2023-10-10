using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if (checkBox1.Checked)
                label4.Text += checkBox1.Text+" ";
            if (checkBox2.Checked)
                label4.Text += checkBox2.Text+" ";
            if (checkBox3.Checked)
                label4.Text += checkBox3.Text+" ";
            if (checkBox4.Checked)
                label4.Text += checkBox4.Text+" ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", 16, FontStyle.Bold);
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
        }
    }
}
