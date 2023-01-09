using System;
using System.Globalization;

namespace ExFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial S/N");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre como valor de deposito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, DepositoInicial); 
            }
            else
            {
                conta = new ContaBancaria(numero, titular);

            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
    