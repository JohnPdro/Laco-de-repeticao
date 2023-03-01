using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laço_de_repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lstFor.Items.Add(1);
            //lstFor.Items.Add(2);
            //lstFor.Items.Add(3);
            //lstFor.Items.Add(4);
            //lstFor.Items.Add(5);
            //lstFor.Items.Add(6);
            //lstFor.Items.Add(7);
            //lstFor.Items.Add(8);
            //lstFor.Items.Add(9);
            //lstFor.Items.Add(10);

            //vamos fazer um laço de repetição para que preencha algund valores

            //for (int valor = 0; valor <= 10; valor++)
            //{
            //    lstFor.Items.Add(valor);
            //}

            //for (int valor = 0; valor <= 10; valor +=2)
            //{
            //    lstFor.Items.Add(valor);
            //}

            int vezes = 0;
            do
            {
                lstFor.Items.Add(vezes);
                vezes++;
            }
            while (vezes <= 1000);

        }
    }
}
