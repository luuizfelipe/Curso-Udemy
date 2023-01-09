using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy
{
    internal class para
    {
        static void mains3(string[]args)
        {
            System.Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= N; i++)
            {
                Console.Write("Valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.Write("soma = " + soma);
            
        }
    }
}
