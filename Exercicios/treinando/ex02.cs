using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace Exercicios
{
    internal class ex02
    {
        static void Main (string[] args)
        {

            Console.WriteLine("Entre com seu nome completo");
            string nomeC = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa");
            double quarto = double.Parse(Console.ReadLine());

            Console.WriteLine("entre com o preço de um produto");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome,idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nomeC);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
