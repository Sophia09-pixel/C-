using System;
using System.Globalization;
namespace Resolvendo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Funcionario:");
            Funcionario p1 = new Funcionario();

            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            p1.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            p1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario: {p1.Nome}, ${p1.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine());
            p1.AumentarSalario(porcent);

            Console.WriteLine();
            Console.Write($"Dados Atualizados: {p1.SalarioLiquido()}");




        }
    }
}
