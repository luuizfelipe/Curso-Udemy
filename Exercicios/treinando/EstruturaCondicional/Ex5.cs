using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaCondicional
{
    internal class Ex5
    {
        static void mian07(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if(codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
