using Original.Domain;

namespace Original.Infrastructure
{
    public class OrderRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine("Guardando orden en la base de datos...");
            Console.WriteLine($"Orden guardada.");
        }
    }
}
