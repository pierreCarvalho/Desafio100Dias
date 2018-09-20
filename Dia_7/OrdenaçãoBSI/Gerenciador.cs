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


        //merge
        //empilhar e dividir

        public static int meio;
        public static void merge(int[] vetor, int ini,int fim)
        {

            if(ini < fim)
            {
                meio = (ini + fim) / 2;


                if (ini < meio) merge(vetor, 0, meio);
                if (meio +1 < fim) merge(vetor, meio + 1, fim);

                intercalar(vetor, ini, fim);
            }

        }

        public static void intercalar(int[] vetor, int ini,int fim)
        {
            int meio;
            int i, j, k;
            int[] vetorTemporario = new int[vetor.Length];

            if (vetorTemporario == null)
            { 
                Console.WriteLine("Nao hah mais memoria\n");
            }

            meio = (ini + fim) / 2;

            i = ini; //indice da porcao esquerda
            j = meio + 1; //indice da porcao direita
            k = 0; //indice do vetor temporario

            while (i <= meio && j <= fim)
            {
                if (vetor[i] < vetor[j])
                {
                    vetorTemporario[k] = vetor[i]; //elemento da porcao esquerda vem para o temporario
                    ++i;
                }
                else
                {
                    vetorTemporario[k] = vetor[j]; //elemento da porcao direita vem para o temporario
                    ++j;
                }
                ++k;
            }

            if (i == meio + 1)
            {
                while (j <= fim)
                { //nao hah mais elementos na porcao esquerda
                    vetorTemporario[k] = vetor[j];
                    ++j;
                    ++k;
                }
            }
            else
            {
                while (i <= meio)
                {
                    vetorTemporario[k] = vetor[i];
                    ++i;
                    ++k;
                }
            }
            for (i = ini, k = 0; i <= fim; ++i, ++k)
            {
                vetor[i] = vetorTemporario[k];
            }

        }

    }
}
