using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando
{
    internal class ex2
    {
        static void mian02(string[] args)
        {
            double raio, area;
            double pi = 3.14159;
           

            Console.WriteLine("escreva o valor do raio");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("area = " + area.ToString("f4", CultureInfo.InvariantCulture));



        }
    }
}
