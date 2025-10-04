using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFachada
{
    public class InventoryService
    {
        public bool CheckStock(string productID)
        {
            Console.WriteLine($"-> Inventory: Verificando stock para {productID}...");
            return true; // Se asume que hay stock
        }

        public void UpdateStock(string productID)
        {
            Console.WriteLine($"-> Inventory: Stock de {productID} actualizado.");
        }
    }
}
