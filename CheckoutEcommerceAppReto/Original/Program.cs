using Original.Application;
using Original.Domain;

namespace Original
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CREAR NUEVA ORDEN ===");

            Console.Write("Nombre del cliente: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Email del cliente: ");
            string email = Console.ReadLine()!;

            Console.Write("Producto: ");
            string producto = Console.ReadLine()!;

            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine()!);

            Console.Write("Medio de pago: ");
            string medioPago = Console.ReadLine()!;

            // Crear la orden
            Order order = new Order
            {
                NombreCliente = nombre,
                EmailCliente = email,
                Producto = producto,
                Cantidad = cantidad,
                MedioPago = medioPago
            };

            var checkout = new CheckoutService();
            checkout.ProcessOrder(order);

            Console.ReadLine();
        }
    }
}
