namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invoice = new InnvoiceBuilder().SetInvoiceId(1)
                .SetInvoiceMainDetails("ahmed", "ahmed@gmail.com", "010222222")
                .SetBillingAddress("street1", "city1", "state1", "zip1", "country1")
                .SetShippingAddress("street2", "city2", "state2", "zip2", "country2")
                .SetOrderDetails(DateTime.Now, "Credit Card", "USD")
                .CalculateTotalAmount(100, 10, 5)
                .Build();
            Console.WriteLine($"Invoice ID: {invoice.InvoiceId}");
            Console.WriteLine($"Customer: {invoice.CustomerName}");
            Console.WriteLine($"Email: {invoice.CustomerEmail}");
            Console.WriteLine($"Phone: {invoice.CustomerPhone}");
            Console.WriteLine($"Payment Method: {invoice.PaymentMethod}");
            Console.WriteLine($"Currency: {invoice.Currency}");
            Console.WriteLine($"SubTotal: {invoice.SubTotal}");
            Console.WriteLine($"Discount: {invoice.DiscountAmount}");
            Console.WriteLine($"Tax: {invoice.TaxAmount}");
            Console.WriteLine($"Total: {invoice.TotalAmount}");
        }
    }
}
