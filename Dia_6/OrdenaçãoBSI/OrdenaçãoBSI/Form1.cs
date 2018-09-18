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

            int[] vetorSelecao = new int[int.Parse(textBoxGerador.Text)];
            int[] vetorBolha = new int[int.Parse(textBoxGerador.Text)];
            int[] vetorInsercao = new int[int.Parse(textBoxGerador.Text)];

            Gerenciador.populaVetor(vetorBolha);
            Gerenciador.populaVetor(vetorInsercao);
            Gerenciador.populaVetor(vetorSelecao);

            //exibir eles de forma aleatoria
            for (int i = 0; i < vetorBolha.Length; i++)
                textBoxNumeroBolha.AppendText(vetorBolha[i] + "\r\n");

            for (int i = 0; i < vetorSelecao.Length; i++)
                textBoxNumeroSelecao.AppendText(vetorSelecao[i] + "\r\n");

            for (int i = 0; i < vetorInsercao.Length; i++)
                textBoxNumeroInsercao.AppendText(vetorInsercao[i] + "\r\n");

            Gerenciador.selecao(vetorSelecao);
            Gerenciador.insercao(vetorInsercao);
            Gerenciador.bolha(vetorBolha);

            for (int i = 0; i < vetorBolha.Length; i++)
                textBoxBolha.AppendText(vetorBolha[i] + "\r\n");

            for (int i = 0; i < vetorSelecao.Length; i++)
                textBoxSelecao.AppendText(vetorSelecao[i] + "\r\n");

            for (int i = 0; i < vetorInsercao.Length; i++)
                textBoxInsercao.AppendText(vetorInsercao[i] + "\r\n");



        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxGerador.Clear();
            textBoxNumeroBolha.Clear();
            textBoxBolha.Clear();
            textBoxInsercao.Clear();
            textBoxSelecao.Clear();
            textBoxNumeroInsercao.Clear();
            textBoxNumeroSelecao.Clear();
        }

        private void buttonBolha_Click(object sender, EventArgs e)
        {

        }
    }
}
