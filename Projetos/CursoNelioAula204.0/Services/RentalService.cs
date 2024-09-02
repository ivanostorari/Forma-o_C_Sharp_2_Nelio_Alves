using System;
using Curso_Nelio_Aula2040.Entities;

namespace Curso_Nelio_Aula2040.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay) 
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        } 

        public void ProcessInvoice(CarRental carRental) 
        {
        }
    }
}
