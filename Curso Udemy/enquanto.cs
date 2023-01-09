using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso_Udemy
{
    internal class enquanto
    {
        static void main03s(string[] args)
        {
            Console.Write("Digite o número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(x > 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");

        }
    }
}
