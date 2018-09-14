using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeTestes
{
    public partial class Form1 : Form
    {
        String hogwarts;
        String cidade, nome;
        int idade,matricula=0;

        List<Cadastro> lista = new List<Cadastro>();

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            textBoxSaida.Clear();
            foreach (var item in lista)
            {
                textBoxSaida.AppendText("\n" + item.matricula + " -> " + item.nome + " | Idade : " + item.idade + " | Cidade : " + item.cidade + " | Hogwarts : " + item.hogwarts + " \n");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            idade = int.Parse(textBoxIdade.Text);
            nome = textBoxNome.Text;
            cidade = textBoxCidade.Text;

            if (radioButtonGrif.Checked) hogwarts = "Grifinória ";
            if (radioButtonSon.Checked) hogwarts = "Corvinal ";
            if (radioButtonCor.Checked) hogwarts = "Sonserina ";
            if (radioButtonLuf.Checked) hogwarts = "Lufa-Lufa ";
            
            //colocar em uma lista
           
            matricula = matricula + 1;
            lista.Add(new Cadastro(matricula, nome, idade, cidade,hogwarts));

            //consultar
            
            
        }
    }
}
