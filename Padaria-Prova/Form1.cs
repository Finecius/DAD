using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }
        float p=0;
        float t = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show(" Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                listBox1.Items.Add(textBox1.Text + " - " +"R$"+ (p=(int.Parse(textBox2.Text) * float.Parse(textBox3.Text))));
               
            }

            t += p;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text ="R$"+t.ToString();
            MessageBox.Show("Compra efetuada com sucesso", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            t = 0;
            p = 0;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           String a= listBox1.SelectedItem.ToString();
            t-=float.Parse(a.Substring(a.IndexOf("$") +1));
               listBox1.Items.Remove(listBox1.SelectedItem);
            label2.Text = "R$"+t.ToString();
            }
        }
    }

