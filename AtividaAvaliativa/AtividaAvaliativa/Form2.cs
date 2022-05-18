using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividaAvaliativa
{
    public partial class Form2 : Form
    {
        double totaldaCompra = 0;
        public Form2()
        {
            InitializeComponent();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
            totaldaCompra = 0;
            label4.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = totaldaCompra.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Campo Obrigatório (Produto)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Campo Obrigatório (Quantidade)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Campo Obrigatório (Preço)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double total = double.Parse(textBox2.Text)  * double.Parse(textBox3.Text);
                listBox1.Items.Add(textBox1.Text + "-" + total);
                totaldaCompra = totaldaCompra + total;
             }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
