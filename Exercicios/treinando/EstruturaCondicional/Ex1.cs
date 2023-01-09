using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaCondicional
{
    internal class Ex1
    {
        static void mian05 (string[] args)
        {
            int x;

            Console.WriteLine("Digite um numero");

            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("negativo");
            }
            else 
              {

                Console.WriteLine("Não negativo");
            }
        }
    }
}
