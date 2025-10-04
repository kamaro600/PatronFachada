namespace PatronFachada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // El cliente solo necesita una instancia de la Fachada
            OnlineShop shopFacade = new OnlineShop();
            string item = "Laptop HP";
            decimal itemPrice = 2200.00m;
            // El cliente realiza la compra con una sola llamada.
            // No tiene que saber nada de inventarios, pagos o notificaciones.
            shopFacade.PlaceOrder(item, itemPrice);
        }
    }
}
