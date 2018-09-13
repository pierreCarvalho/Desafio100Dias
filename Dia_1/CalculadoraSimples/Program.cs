using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à calculadora");
            Console.WriteLine("Insira nessa ordem o valor,op,valor");
            float valor1 = float.Parse(Console.ReadLine());
            Char op = char.Parse(Console.ReadLine());
            float valor2 = float.Parse(Console.ReadLine());

            //Calcular calcula = new Calcular();
            Calcular.Resultado(valor1, op, valor2);
        }
    }
}
