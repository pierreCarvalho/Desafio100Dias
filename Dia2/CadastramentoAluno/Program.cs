using System;
using System.Collections.Generic;

namespace CadastramentoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar lista
            List<Aluno> lista = new List<Aluno>();

            GerenciarLista.PopulaLista(lista);

            GerenciarLista.ExibirLista(lista);

            GerenciarLista.Consultar(lista);
            
        }
    }
}
