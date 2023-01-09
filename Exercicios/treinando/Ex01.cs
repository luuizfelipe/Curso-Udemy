using System.Globalization;

namespace Exercicios.treinando
{
    class Ex01
    {
        static void Main1(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritrorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine($" Produtos:{produto1} cujo o preço é ${preco1:f2}");
            Console.WriteLine($"{produto2}, cujo o preço é ${preco2:f2}");

            Console.WriteLine($"{idade}anos de idade, código{codigo} e gênero: {genero}");

            Console.WriteLine("Medida com oito casas decimais " + medida);
            Console.WriteLine($"Arredondamento: {medida:f4}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}