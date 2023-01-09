using System;

namespace Curso_Udemy
{
    internal class EntradaDedados
    {
        static void main2 (string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];   
            string b = v[1];
            string c = v[2];


            Console.WriteLine("escreva uma frase: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
