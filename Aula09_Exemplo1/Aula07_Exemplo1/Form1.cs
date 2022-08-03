using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07_Exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            thread.Abort();
        }
        private void splashScreen()
        {
            Application.Run(new splashScreen());
                
        }

        private void marcarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
