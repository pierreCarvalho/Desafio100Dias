using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaçãoBSI
{
    class Gerenciador
    {
        //gerar numeros aleatorios
        public static void populaVetor(int[] vetor)
        {
            Random gerador = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(100);
            }
        }

        //ordenar coisas

        //bolha
        public static void bolha(int[] vetor)
        {
            int tmp;
            bool houveTroca;

            do
            {
                houveTroca = false; //marca que nao houveTroca
                for (int i = 0; i < vetor.Length - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        tmp = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = tmp;
                        houveTroca = true;
                    }
                }
            } while (houveTroca);

        }

        //insercao
        public static void insercao(int[] vetor)
        {
            int tmp;
            int j;
            for (int i = 1; i < vetor.Length; i++)
            {
                tmp = vetor[i];
                for (j = i - 1; j >= 0 && tmp < vetor[j]; j--)
                {
                    vetor[j + 1] = vetor[j];
                }
                vetor[j + 1] = tmp;
            }

        }

        //selecao
        public static void selecao(int[] vetor)
        {
            long i, j, posMenor;
            int tmp;

            for (i = 0; i < vetor.Length - 1; i++)
            {
                posMenor = i;
                for (j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[posMenor]) posMenor = j;
                }
                if (i != posMenor)
                {
                    tmp = vetor[i];
                    vetor[i] = vetor[posMenor];
                    vetor[posMenor] = tmp;
                }
            }


        }

    }
}
