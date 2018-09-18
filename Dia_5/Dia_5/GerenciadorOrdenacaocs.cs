using System;
using System.Collections.Generic;
using System.Text;

namespace Dia_5
{
    class GerenciadorOrdenacaocs
    {
        //exibir uma lista/vetor
        public static void exibirVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }


        }
        //popular uma lista/vetor
        public static void populaVetor(int[] vetor)
        {
            Random gerador = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(100); 
            }

        }
        //ordenar uma lista/vetor
        public static void bolha(int[] vetor)
        {

            bool houveTroca;
            int tmp = 0;
            do {
                houveTroca = false;
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        tmp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = tmp;
                        houveTroca = true;
                    }
                }
            }while(houveTroca);

        }
    }
}
