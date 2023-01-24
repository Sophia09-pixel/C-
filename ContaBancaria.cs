using System;
using System.Globalization;
namespace Saldo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com  o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depóito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.WriteLine("Entre o valor de deposito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dadoss da conta atualizados:");
            Console.WriteLine(conta);
            
        }
    }
}
