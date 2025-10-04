using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFachada
{
    public class OnlineShop
    {
        private readonly InventoryService _inventoryService;
        private readonly PaymentService _paymentService;
        private readonly NotificationService _notificationService;

        public OnlineShop()
        {
            _inventoryService = new InventoryService();
            _paymentService = new PaymentService();
            _notificationService = new NotificationService();
        }

        public void PlaceOrder(string productID, decimal price)
        {
            Console.WriteLine("\n*** INICIANDO PROCESO DE COMPRA ***");

            // 1. Llama al primer subsistema
            if (!_inventoryService.CheckStock(productID))
            {
                Console.WriteLine("!!! COMPRA FALLIDA: Producto agotado.");
                return;
            }

            // 2. Llama al segundo subsistema
            if (!_paymentService.ProcessPayment(productID, price))
            {
                Console.WriteLine("!!! COMPRA FALLIDA: Pago rechazado.");
                return;
            }

            // 3. Llama a los subsistemas restantes
            _inventoryService.UpdateStock(productID);
            _notificationService.SendConfirmation(productID);

            Console.WriteLine("*** PROCESO DE COMPRA COMPLETADO CON ÉXITO. ***");
        }
    }
}
