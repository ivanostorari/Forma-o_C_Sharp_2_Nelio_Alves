namespace Curso_Nelio_Aula2050.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else 
            { 
                return amount * 0.15; 
            }
        }
    }
}
