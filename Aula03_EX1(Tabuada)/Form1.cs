using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03_EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            for (int i = 0; i <= 10; i++)
                listBox1.Items.Add(numero + " * " + i + "=" + numero * i);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}
