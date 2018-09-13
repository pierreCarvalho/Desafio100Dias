using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    class Calcular
    {
        public Calcular()
        {
        }
        public static void  Resultado(float valor1,char op,float valor2)
        {
            if (op.Equals('+'))
            {
                Console.WriteLine("A soma de " + valor1 + " e " + valor2 + " é :" + (valor1 + valor2));
                Console.ReadKey(true);
            }
            else if (op.Equals('-'))
            {
                Console.WriteLine("A subtração de" + valor1 + " e " + valor2 + " é :" + (valor1 - valor2));
                Console.ReadKey(true);
            }
            else if (op.Equals('*'))
            {
                Console.WriteLine("A multiplicação de " + valor1 + " e " + valor2 + " é :" + (valor1 * valor2));
                Console.ReadKey(true);
            }
            else if (op.Equals('/'))
            {
                Console.WriteLine("A divisão de" + valor1 + " e " + valor2 + " é :" + (valor1 / valor2));
                Console.ReadKey(true);
            }

        }
    }
}
