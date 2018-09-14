using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CadastramentoAluno
{
    class GerenciarLista
    {
        public static void PopulaLista(List<Aluno> lista)
        {
            string nome;
            int matricula = 1, idade;

            Console.WriteLine("Quantas pessoas quer cadastrar?");
            int qtd = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Insira seu nome");
                nome = Console.ReadLine();
                Console.WriteLine("Insira sua idade");
                idade = int.Parse(Console.ReadLine());
                lista.Add(new Aluno(nome, matricula, idade));
                matricula += 1;
            }
        }
        public static void ExibirLista(List<Aluno> lista)
        {
            
            foreach (var item in lista)
            {
                Console.WriteLine(item.Matricula + " -> " + item.Nome + " Idade : " + item.Idade);
            }
        }
        public static void Consultar(List<Aluno> lista)
        {
            //consultado por matricula
            Console.WriteLine("Digite sua matricula ");
            int valor = int.Parse(Console.ReadLine());

            foreach (var item in lista)
            {
                if (item.Matricula.Equals(valor))
                {
                    Console.WriteLine("Matricula : "+ item.Matricula + " ->  Aluno : " + item.Nome + " Idade : " + item.Idade);
                    break;
                }
            }
        }
        


}
}
