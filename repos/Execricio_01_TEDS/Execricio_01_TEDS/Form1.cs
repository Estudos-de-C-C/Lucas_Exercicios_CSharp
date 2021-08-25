using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execricio_01_TEDS
{
    public partial class Form1 : Form
    {

        private double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorCompra = double.Parse(valor_compra.Text);
            int valorParcelas = int.Parse(valor_parcela.Text);


            if (valorCompra <= 0 || valorParcelas < 0)
            {
                throw new Exception("Valor inválido");
            }

            if (valorParcelas <= 1)
            {
                this.result = (double)(valorCompra - (valorCompra * 0.1));
            }
            else if (valorParcelas > 1 && valorParcelas <= 5)
            {
                this.result = valorCompra;
            }
            else
            {
                this.result = (double)(valorCompra + (valorCompra * 0.07));
            }

            resultado.Text = Convert.ToString(this.result);
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

    }
}
