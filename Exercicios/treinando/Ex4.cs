using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando
{
    internal class Ex4
    {
        static void main04 (string[] args)
        {
            int funcionario, hours;
            double salary,valor;


            Console.WriteLine("informe a quantidade de funcionario");
            funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a quantidade de horas trabalhada");
            hours = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor da hora trabalhada");
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor = salary * hours;

            Console.WriteLine("numero de funcionario" + funcionario);

            Console.WriteLine("Salario R$ " + valor);

        }
    }
}
