using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaCondicional
{
    internal class Ex3
    {
        static void main6(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if(x % y == 0 || y % x == 0)
            {
                Console.WriteLine("são multiplos");

            }
            else
            {
                Console.WriteLine("não são multiplos");
            }
        }
    }
}
