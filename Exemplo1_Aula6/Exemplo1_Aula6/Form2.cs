using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1_Aula6
{
    public partial class Form2 : Form
    {
        float calc;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    calc = (float.Parse(textBox1.Text) * float.Parse(textBox3.Text));
                    label5.Text = calc.ToString("0.00");
                }
                else if (radioButton2.Checked)
                {

                    calc = (float.Parse(textBox2.Text) * float.Parse(textBox3.Text));
                    label5.Text = calc.ToString("0.00");
                }
                else
                    MessageBox.Show("Selecione um combustivel", "ATENÇÃO", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            } //try
            catch (Exception)
            {
                MessageBox.Show("Dados incorretos");
                //MessageBox.show(ex.Message);
            }
        }
    }
}
