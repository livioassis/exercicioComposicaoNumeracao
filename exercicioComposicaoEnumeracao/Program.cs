using System;
using System.Globalization;
using exercicioComposicaoEnumeracao.Entities;
using exercicioComposicaoEnumeracao.Entities.Enums;

namespace exercicioComposicaoEnumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prdName = Console.ReadLine();
                Console.Write("Product price: ");
                double prdPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(prdName, prdPrice);

                Console.Write("Quantity: ");
                int prdQuantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(prdQuantity, prdPrice, product);

                order.AddItem(item);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order items:");
            Console.WriteLine(order);
        }
    }
}
