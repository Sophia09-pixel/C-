using System;
using Course.Entities;
using System.IO;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut  <= checkIn)
            {
                Console.WriteLine("Error in reervation: Check-out must be after check-in date");
            }
            else
            {
                Reservetion reservation = new Reservetion(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if(checkIn < now || checkOut < now)
                {
                    Console.Write("Error in reservation: Reservation date for update must be future dates");

                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}");
                }
            }

    

        }
    }
}
