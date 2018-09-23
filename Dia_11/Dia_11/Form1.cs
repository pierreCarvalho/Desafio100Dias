using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            String[] dados = { textBoxNome.Text, textBoxMatricula.Text, textBoxTelefone.Text };


            //inserir dados na tabela

            dataGridViewCadastrados.Rows.Add(dados);

            textBoxMatricula.Clear();
            textBoxNome.Clear();
            textBoxTelefone.Clear();


        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

             int index = dataGridViewCadastrados.CurrentRow.Index;
             dataGridViewCadastrados.Rows.RemoveAt(index);
            
        }
    }
}
