using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFachada
{
    public class PaymentService
    {
        public bool ProcessPayment(string productID, decimal amount)
        {
            Console.WriteLine($"-> Payment: Procesando pago de {amount:C} para {productID}...");
            // Lógica de pasarela
            return true; // pago exitoso
        }
    }
}
