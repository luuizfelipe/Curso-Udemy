using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaWhile
{
    internal class Ex1
    {
        static void mian03(string[] args)
        {
            Console.WriteLine("Escreva a senha correta: ");

           int A = int.Parse(Console.ReadLine());

            while (A != 2002)
            {
                Console.Write("Acesso Negado !");

                Console.Write("Digite outro número: ");
                A = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("acesso Permitido !!");
            
        }
    }
}
