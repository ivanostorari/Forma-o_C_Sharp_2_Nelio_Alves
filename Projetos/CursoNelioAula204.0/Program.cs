using System;
using System.Globalization;
using Curso_Nelio_Aula2040.Entities;

namespace Curso_Nelio_Aula2040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model; ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (ss/MM/yyyy hh:ss): ");
            DateTime star = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (ss/MM/yyyy hh:ss): ");
            DateTime Finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(star, Finish, new Vehicle(model));
        }
    }
}

