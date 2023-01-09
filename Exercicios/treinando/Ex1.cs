using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando
{
    internal class Ex1
    {
        static void main1 (string[] args)
        {
            int a, b, soma;
            

            Console.WriteLine("Digite o primeiro numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("soma = " + soma);

        }
    }
}
