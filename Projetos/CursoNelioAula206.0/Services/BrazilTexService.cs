using CursoNelioAula2060.Services;

namespace Curso_Nelio_Aula2060.Services
{
    class BrazilTaxService : ITaxService
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
