using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            String convenio = "Não";
            if (checkBoxConvenio.Checked) convenio = "Sim";
            String[] dados = { textBoxData.Text, textBoxHora.Text, textBoxNome.Text,comboBoxMedico.Text, convenio };


            dataGridViewAgenda.Rows.Add(dados);

            limpaCampos();
        }


        private void limpaCampos()
        {
            textBoxData.Clear();
            textBoxHora.Clear();
            textBoxNome.Clear();
            checkBoxConvenio.Checked = false;
            comboBoxMedico.ResetText();

        }
    }
}
