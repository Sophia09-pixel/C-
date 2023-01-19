using System;
using System.Globalization;

namespace resolvendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dado do produto: ");

            Produto p1 = new Produto();


            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto:{p1}");

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionados ao estoque:  ");
            int qte = int.Parse(Console.ReadLine());

            p1.AdicionarProdutos(qte);

            Console.WriteLine($"Dados Atualizados: {p1} ");

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a serem removidos: ");
            int rev = int.Parse(Console.ReadLine());

            p1.RemoverProdutos(rev);

            Console.WriteLine($"Dados Atualizados: {p1}");




        }
    }
}
