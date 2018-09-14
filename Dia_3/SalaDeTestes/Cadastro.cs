using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeTestes
{
    class Cadastro
    {
        public int matricula;
        public String nome;
        public int idade;
        public String hogwarts;
        public String cidade;

        public Cadastro(int matricula, string nome, int idade, string cidade,string hogwarts)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.idade = idade;
            this.cidade = cidade;
            this.hogwarts = hogwarts;
        }
    }
}
