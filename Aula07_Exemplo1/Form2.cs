using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07_Exemplo1
{
    public partial class Form2 : Form
    {
        int op = 0;
        String caminho = Directory.GetCurrentDirectory();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamWriter arquivo;

            if (System.IO.File.Exists(caminho + "\\" + nome_arq + ".txt"))
                File.Delete(caminho + "\\" + nome_arq + ".txt");

            arquivo = new StreamWriter(caminho+"\\" + nome_arq + ".txt");
            foreach (Label controle in tableLayoutPanel1.Controls)
            {
                arquivo.WriteLine(controle.Text);
            }
            arquivo.Close();

            MessageBox.Show("Arquivo Gravado com Sucesso!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            op = 6;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            op = 7;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            op = 6;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            op = 7;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            op = 8;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            op = 9;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            op = 10;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            op = 8;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            op = 9;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            op = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op == 6)
            {
                label6.Text = textBox2.Text;
            }
            else if (op == 7)
            {
                label7.Text = textBox2.Text;
            }
            else if (op == 8)
            {
                label8.Text = textBox2.Text;
            }
            else if (op == 9)
            {
                label9.Text = textBox2.Text;
            }
            else if (op == 10)
            {
                label10.Text = textBox2.Text;
            }
            else
                MessageBox.Show("Escolha um horário");
        }
    }
}
