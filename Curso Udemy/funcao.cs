﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Udemy
{
    internal class funcao
    {
        static void main1(string[] args)
        {
            Console.WriteLine("Digite 3 números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

            /*
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);

            }
            else if(n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }*/
        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if(a > b && a >c)
            {
                m = a;
            }
            else if( b > c)
            {
                m = b;  
            }
            else
            {
                m = c;  
            }
            return m;
        }
    }
}
