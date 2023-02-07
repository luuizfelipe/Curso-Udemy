using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            
        }

        /* public Produto(string nome, double preco) : this()
         {
             Nome = nome;
             Preco = preco;

         }
        */

        /*
           // Método Construtor
                
            public Produto(string nome, int preco, int quantidade)
             {
                    Nome = nome;
                    Quantidade = quantidade;
                    Preco = preco;
             }
         */

        /*
          // Método Sobrecarga

           public Produto(string nome, int preco, int quantidade)
            {
                   Nome = nome;
                   Preco = preco;
                   Quantidade = 0;
            }
        */
        public Produto (string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) { 
                    _nome = value;
                }
            }
        }

        /*public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade;}
        }
        */

        /* public string GetNome()
         {
             return _nome;
         }

         public void SetNome(string nome)
         {
             if(nome != null && nome.Length > 1) 
             _nome = nome;
         }*/

        public double ValorTotalEmEstroque
        {
            get { return Preco * Quantidade; }
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;

        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        
 
        public override string ToString()
        {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstroque.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}

