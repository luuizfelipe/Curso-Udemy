using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Orientado
{
    internal class Ex1
    {
        static void mais234 (string[] args)
        {
            Pessoa p1,p2;

            p1= new Pessoa();
            p2= new Pessoa();  

            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.Write("Nome:");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.Write("Nome:");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

           if(p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }


        }
    }
}
