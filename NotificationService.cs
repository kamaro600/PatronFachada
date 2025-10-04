using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFachada
{
    public class NotificationService
    {
        public void SendConfirmation(string productID)
        {
            Console.WriteLine($"-> Notification: Enviando confirmación del pedido de {productID} por correo.");
        }
    }
}
