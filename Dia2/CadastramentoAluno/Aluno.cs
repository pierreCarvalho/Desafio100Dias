using System;
using System.Collections.Generic;
using System.Text;

namespace CadastramentoAluno
{
    class Aluno
    {
        private String nome;
        private int matricula;
        private int idade;

        public Aluno(String nome,int matricula,int idade)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
