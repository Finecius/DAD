using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula09_Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {//(e.KeyChar == 13) ----   13 na tabela ASCII é a tecla enter
                if (textBox1.Text != string.Empty)
                {
                    maskedTextBox1.Focus();
                }
                else
                    MessageBox.Show("Campo vazio!");
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Convert.ToDateTime(maskedTextBox1.Text);
                    listBox1.Items.Add(textBox1.Text);
                    listBox2.Items.Add(maskedTextBox1.Text);
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                    textBox1.Focus();
                }catch(Exception ex)
                {
                    MessageBox.Show("Data inválida");
                    maskedTextBox1.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
                textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 1)
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 2)
                textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            else
                MessageBox.Show("Selecione um candidato");
            listBox3.ClearSelected();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try {
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
                
               
                }catch(Exception ex)
            {
                MessageBox.Show("Nenhum evento Selecionado!");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Remove(listBox2.SelectedItem);
              
                

            } catch (Exception ex)
            {
                MessageBox.Show("Nenhum evento Selecionado!");
            }
        }
    }
}
