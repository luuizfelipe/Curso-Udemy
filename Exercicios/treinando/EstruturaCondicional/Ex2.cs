using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaCondicional
{
    internal class Ex2
    {
        static void main06(string[] args)
        {
            int x;

            Console.WriteLine("digite um numero");
            x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}
