using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6_Ex1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calc;

            try
            {
                if (comboBox1.SelectedIndex == 0)
                {

                    calc = 5.5*int.Parse(textBox1.Text);
                    label4.Text ="R$"+ calc.ToString("0.00");
                } else if (comboBox1.SelectedIndex == 1) {

                    calc = 10.8*int.Parse(textBox1.Text);
                    label4.Text ="R$"+ calc.ToString("0.00");
                } else
                    MessageBox.Show("Selecione um Frasco", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            textBox1.Text = "0";
            label4.Text = "0";
            //comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
        }
    }
}
