﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Orientado
{
    internal class ConversorMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia* cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
