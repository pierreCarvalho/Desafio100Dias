using System;

namespace Dia_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];

            GerenciadorOrdenacaocs.populaVetor(vetor);
            GerenciadorOrdenacaocs.exibirVetor(vetor);
            Console.WriteLine("--------------");
            GerenciadorOrdenacaocs.bolha(vetor);
            GerenciadorOrdenacaocs.exibirVetor(vetor);



        }
    }
}
