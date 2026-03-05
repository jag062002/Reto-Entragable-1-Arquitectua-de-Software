using Original.Domain;

namespace Original.Infrastructure
{
    public class EmailService
    {
        public void SendConfirmation(Order order)
        {
            Console.WriteLine("Enviando correo de confirmación...");

            Console.WriteLine($"Correo enviado a: {order.EmailCliente}");
            Console.WriteLine("Gracias por su compra.");
        }
    }
}
