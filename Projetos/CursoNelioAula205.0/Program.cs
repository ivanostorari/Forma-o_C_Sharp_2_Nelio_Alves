
using System;
using System.Globalization;
using Curso_Nelio_Aula2050.Entities;
using Curso_Nelio_Aula2050.Services;

namespace Curso_Nelio_Aula2050
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime star = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:ss): ");
            DateTime Finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine()); CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine()); CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(star, Finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice);
        }
    }
}

