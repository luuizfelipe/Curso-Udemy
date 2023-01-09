using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando
{
    internal class Ex3
    {
        static void main03(string[] args)
        {
            int a, b, c, d,soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            soma = (a * b) - (c * d);

            Console.WriteLine(soma);
        }
    }
}
