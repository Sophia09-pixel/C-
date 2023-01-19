using System;
using System.Globalization;

namespace Resolvendo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura do retangulo: ");
            Retangulo ret = new Retangulo();

            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area: {ret.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
