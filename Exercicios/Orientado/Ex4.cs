using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Orientado
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual é a cotação do dolar ?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantis dolares você vai comprar");
            double quantia= double.Parse(Console.ReadLine());

            double result = ConversorMoeda.DolarParaReal(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais =" + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
