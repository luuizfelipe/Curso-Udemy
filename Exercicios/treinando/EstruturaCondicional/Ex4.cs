using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.treinando.EstruturaCondicional
{
    internal class Ex4
    {
        static void main06(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int Hi = int.Parse(valores[0]);
            int Hf = int.Parse(valores[1]);

            int duracao;

            if(Hi < Hf)
            {
                duracao = Hf - Hi;

            }
            else
            {
                duracao = 24 - Hi + Hf;
            }

            Console.WriteLine("O jogo durou " + duracao + " horas");

            

        }
    }
}
