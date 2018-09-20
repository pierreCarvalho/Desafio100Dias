using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaçãoBSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxGerador_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            //criar uma lista/vetor

            int[] vetor = new int[int.Parse(textBoxGerador.Text)];

            Gerenciador.populaVetor(vetor);

            if (comboBoxMetodos.Text.Equals("Seleção"))
            {
                textBoxNumeros.Clear();
                Gerenciador.selecao(vetor);
                textBoxNumeros.AppendText("Seleção \n");
                exibirVetor(vetor);

            }
            else if (comboBoxMetodos.Text.Equals("Bolha"))
            {
                textBoxNumeros.Clear();
                Gerenciador.bolha(vetor);
                textBoxNumeros.AppendText("Bolha \n");
                exibirVetor(vetor);
            }
            else if (comboBoxMetodos.Text.Equals("Inserção"))
            {
                textBoxNumeros.Clear();
                Gerenciador.insercao(vetor);
                textBoxNumeros.AppendText("Inserção \n");
                exibirVetor(vetor);
            }
            else if (comboBoxMetodos.Text.Equals("Merge"))
            {
                textBoxNumeros.Clear();
                Gerenciador.merge(vetor,0,vetor.Length - 1);
                textBoxNumeros.AppendText("Merge \n");
                exibirVetor(vetor);
            }

        }

        private void exibirVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                textBoxNumeros.AppendText(vetor[i] + "\r\n");
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
        }

        private void buttonBolha_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
