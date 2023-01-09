using System;
using System.Globalization;

namespace Curso_Udemy
{
    class metroterreno
    {
        static void main1(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.WriteLine("Digite a largura do Terreno");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do Terreno");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o metro quadrado do Terreno");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}
