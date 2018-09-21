using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_8
{
    public partial class Form1 : Form
    {
        float valor1, valor2;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(textBoxValores.Text);
            textBoxValores.Clear();
            op = '+';

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(textBoxValores.Text);
            textBoxValores.Clear();
            op = '-';
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(textBoxValores.Text);
            textBoxValores.Clear();
            op = '*';
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = float.Parse(textBoxValores.Text);
            textBoxValores.Clear();

            Resultado(valor1, valor2, op);

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(textBoxValores.Text);
            textBoxValores.Clear();
            op = '/';
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("1");
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("2");
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("3");
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("4");
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("5");
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("6");
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("7");
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("8");
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("9");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText("0");
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            textBoxValores.AppendText(",");
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxValores.Clear();
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            double valorRaiz;
            valorRaiz = float.Parse(textBoxValores.Text);
            textBoxValores.Clear();
            valorRaiz = Math.Sqrt(valorRaiz);
            textBoxValores.AppendText(valorRaiz + "");

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resultado(float valor1,float valor2, char op)
        {
            //faz a conta
            float resultado;
            switch (op)
            {
                case '+':
                    resultado = valor1 + valor2;
                    textBoxValores.AppendText(resultado+ "");
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    textBoxValores.AppendText(resultado + "");
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    textBoxValores.AppendText(resultado + "");
                    break;
                case '/':
                    resultado = valor1 / valor2;
                    textBoxValores.AppendText(resultado + "");
                    break;
                default:
                    textBoxValores.AppendText("ERRO");
                    break;
            }
        }
    }
}
