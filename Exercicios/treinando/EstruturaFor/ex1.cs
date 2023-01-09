using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaFor
{
    internal class ex1
    {
        static void mians3n(string[] args)
        {
            Console.WriteLine("Digite um número");

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i <= X; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
