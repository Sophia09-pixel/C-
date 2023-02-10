using System;
using System.Globalization;

namespace Resolvendo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de produtos:  ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o nome e o preço dos produtos: ");
            Product[] vect = new Product[n];

            for (int i =  0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Preco = price };
            }

            double soma = 0;

            for(int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine($"Media:{media.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
