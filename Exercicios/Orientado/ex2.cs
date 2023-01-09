using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Orientado
{
    internal class ex2
    {
        static void Main (string[] args)
        {
            funcionario f1, f2;

            f1 = new funcionario();
            f2 = new funcionario();

            Console.WriteLine("Digite os dados da primeira funcionario");
            Console.Write("Nome:");
            f1.nome = Console.ReadLine();
            f1.salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da primeira funcionario");
            Console.Write("Nome:");
            f2.nome = Console.ReadLine();
            f2.salario = int.Parse(Console.ReadLine());

            double media;

            media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário médio = " + media);

            


        }
    }
}
