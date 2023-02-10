using System;
using System.Globalization;

namespace Resolvendo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vect = new Estudante[10];

            Console.Write("How many room will be retend?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0;i <n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Estudante(name,email);
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i+ ":" + vect[i]);
                }
            }


        }
    }
}
