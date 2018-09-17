using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_4
{
    public partial class Form1 : Form
    {
        String EstadoCivil;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //salvar arquivo em um arquivo.txt
            if (radioButtonSolteiro.Checked) EstadoCivil = "Solteiro";
            else EstadoCivil = "Casado";

            String[] linhas = { textBoxNome.Text, textBoxIdade.Text, EstadoCivil };

            System.IO.File.WriteAllLines(@"C:\Users\Usuário\Desktop\CC-20180719T175214Z-001\CC\projeto\" + textBoxNome.Text + ".txt", linhas);

        }

        private void radioButtonCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            string[] texto = System.IO.File.ReadAllLines(@"C:\Users\Usuário\Desktop\CC-20180719T175214Z-001\CC\projeto\"+textBoxConsulta.Text +".txt");
            foreach (var item in texto)
            {
                textBoxExibir.AppendText(item + " \r\n "  );
            }
        }
    }
}
