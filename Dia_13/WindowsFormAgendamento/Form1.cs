using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAgendamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            String convenio = "Não";
            //pegar os dados e mostrar na tabela
            if (checkBoxConvenio.Checked) convenio = "Sim";


            String[] dados = { textBoxNome.Text, textBoxEmail.Text, textBoxTelefone.Text, textBoxData.Text,textBoxHora.Text,textBoxMedico.Text,convenio};
 
            dataGridViewAgenda.Rows.Add(dados);

            limpaCampos();

        }

        private void limpaCampos()
        {
            textBoxNome.Clear();
            textBoxData.Clear();
            textBoxEmail.Clear();
            textBoxHora.Clear();
            textBoxMedico.Clear();
            textBoxTelefone.Clear();
            checkBoxConvenio.Checked = false;
        }
    
            //gravar esses dados em algum lugar
        

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
