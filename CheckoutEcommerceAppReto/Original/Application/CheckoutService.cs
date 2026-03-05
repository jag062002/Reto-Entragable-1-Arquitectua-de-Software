using Original.Domain;
using Original.Infrastructure;


// Esto es una capa de alto nivel

namespace Original.Application
{
    public class CheckoutService
    {
        private StockService _stockService = new StockService(); // Esto es una capa de bajo nivel
        private PaymentService _paymentService = new PaymentService(); // Esto es una capa de bajo nivel
        private InvoiceService _invoiceService = new InvoiceService(); // Esto es una capa de bajo nivel
        private EmailService _emailService = new EmailService(); // Esto es una capa de bajo nivel 
        private OrderRepository _orderRepository = new OrderRepository(); // Esto es una capa de bajo nivel

        public void ProcessOrder(Order order)
        {
            // Validamos stock
            if (!_stockService.ValidateStock(order)) return;           

            // Validamos pago y sus montos
            if (!_paymentService.ProcessPayment(order)) return;
            

            _invoiceService.GenerateInvoice(order);
            _emailService.SendConfirmation(order);
            _orderRepository.Save(order);

            Console.WriteLine("Compra finalizada correctamente");
        }
    }
}


/*
 if (order.PaymentMethod == "PayPal")
{
    decimal commission = order.Total * 0.05m;
    Console.WriteLine($"Comisión PayPal: {commission:C}");
}
*/