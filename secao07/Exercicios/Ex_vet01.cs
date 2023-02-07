using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao07.Exercicios
{
    internal class Ex_vet01
    {
        /* static void Main(string[] args)
         {
             int n = int.Parse(Console.ReadLine());

             Estudantes[] vect = new Estudantes[n];

             for(int i = 0; i < n; i++)
             {
                 string nome = Console.ReadLine();
                 string email = Console.ReadLine();
                 vect[i] =  new Estudantes { Name = name, Email = email };
             }
         }*/

        static void Main(string[] args)
        {
            Estudantes[] vect = new Estudantes[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome:");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes(name, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null ) { 
                Console.WriteLine(i + ": " + vect[i]);}
            }
        }

    }
}
