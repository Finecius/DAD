using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula7_Ex1
{
    public partial class Form2 : Form
    {
        int op = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op == 6)
            {
                label6.Text = textBox2.Text;
            }
            if (op == 7)
            {
                label7.Text = textBox2.Text;
            }
            if (op == 8)
            {
                label8.Text = textBox2.Text;
            }
            if (op == 9)
            {
                label9.Text = textBox2.Text;
            }
            if (op == 10)
            {
                label10.Text = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Escolha um horário!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label6.Text != "Disponível")
            {
                MessageBox.Show("Horário Indisponível!!");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
              textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
            if (System.IO.File.Exists("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + textBox1.Text + ".txt"))
            {
                StreamReader file = new StreamReader("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + textBox1.Text + ".txt");
                string line;
                int o = 6;
                while ((line = file.ReadLine()) != "08:00")
                {
                    if (o == 6)
                        label6.Text = line;

                    if (o == 7)
                        label7.Text = line;

                    if (o == 7)
                        label7.Text = line;

                    if (o == 8)
                        label8.Text = line;

                    if (o == 9)
                        label9.Text = line;

                    if (o == 10)
                        label10.Text = line;

                    o++;
                }
                file.Close();
            }
            else
            {
                label6.Text = "Disponível";
                label7.Text = "Disponível";
                label8.Text = "Disponível";
                label9.Text = "Disponível";
                label10.Text = "Disponível";
            }


            //ou

         // textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
        }
     

        private void label6_Click(object sender, EventArgs e)
        {
            op = 6;
            
            label6.BackColor = Color.Red;
            label1.BackColor = Color.Red;
             
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            op = 7;
           
            label7.BackColor = Color.Red;
            label2.BackColor = Color.Red;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            op = 8;
        
            label8.BackColor = Color.Red;
            label3.BackColor = Color.Red;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            op = 9;
         
            label9.BackColor = Color.Red;
            label4.BackColor = Color.Red;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            op = 10;
      
            label10.BackColor = Color.Red;
            label5.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamWriter arquivo;

            if (System.IO.File.Exists("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + nome_arq + ".txt"))
            {
                File.Delete("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + nome_arq + ".txt");
            }
            arquivo = new StreamWriter("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + nome_arq + ".txt");
            foreach (Label controle in tableLayoutPanel1.Controls)
            {
                arquivo.WriteLine(controle.Text);
            }
            arquivo.Close();

            MessageBox.Show("Arquivo Gravado com sucesso!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            if (System.IO.File.Exists("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + nome_arq + ".txt"))
            {
                MessageBox.Show("Já existe consulta para esse dia!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.OpenRead("D:\\DAD(C#)\\Exemplos\\Aula7-Ex1\\" + nome_arq+".txt"); 
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label7.Text != "Disponível")
            {
                MessageBox.Show("Horário Indisponível!!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label8.Text != "Disponível")
            {
                MessageBox.Show("Horário Indisponível!!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "Disponível")
            {
                MessageBox.Show("Horário Indisponível!!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label10.Text != "Disponível")
            {
                MessageBox.Show("Horário Indisponível!!");
            }
        }

        private void label6_DoubleClick(object sender, EventArgs e)
        {
            if (label6.Text != "Disponível")
            {
              var a=  MessageBox.Show("Quer mesmo remover este paciente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(a == DialogResult.Yes)
                {
                    label6.Text = "Disponível";
                }
            }
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            if (label7.Text != "Disponível")
            {
                var a = MessageBox.Show("Quer mesmo remover este paciente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    label7.Text = "Disponível";
                }
            }
        }

        private void label8_DoubleClick(object sender, EventArgs e)
        {
            if (label8.Text != "Disponível")
            {
                var a = MessageBox.Show("Quer mesmo remover este paciente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    label8.Text = "Disponível";
                }
            }
        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            if (label9.Text != "Disponível")
            {
                var a = MessageBox.Show("Quer mesmo remover este paciente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    label9.Text = "Disponível";
                }
            }
        }

        private void label10_DoubleClick(object sender, EventArgs e)
        {
            if (label10.Text != "Disponível")
            {
                var a = MessageBox.Show("Quer mesmo remover este paciente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                {
                    label10.Text = "Disponível";
                }
            }
        }
    }
}
