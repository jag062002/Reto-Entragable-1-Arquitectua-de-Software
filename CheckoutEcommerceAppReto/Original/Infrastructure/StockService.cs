using Original.Domain;

namespace Original.Infrastructure
{
    public class StockService
    {
        public bool ValidateStock(Order order) 
        {
            int stockPrueba = 3;

            Console.WriteLine("Validando stock...");

            if(order.Cantidad > stockPrueba)
            {
                Console.WriteLine("Stock insuficiente");
                return false;
            }

            return true;
        }
    }
}
