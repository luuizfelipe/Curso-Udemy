using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.00,10);

            Console.WriteLine(p.GetNome());

            p.SetNome("Tv 4K");

           /* Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            string Nome = Console.ReadLine();
            Console.Write("preço: ");

             double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          


            Produto p = new Produto(Nome,Preco);

            Console.WriteLine("Dados do produto:" + p);


            Console.WriteLine();
            Console.Write("Quantidade no estoque: ");

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque");
            int qte = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser Removido ao estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);


            p.AdicionarProduto(qte);
            Console.WriteLine("Dados atualizado" + p);

            Console.ReadLine();

          */



        }
    }
}
