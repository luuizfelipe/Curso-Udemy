﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculandoRaio
{
    class Program
    {

        static void Main(string[] args)
        { 
            
        
            Console.Write(" Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);
            

            Console.WriteLine("Circuferencia:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
       
        
    }
}
