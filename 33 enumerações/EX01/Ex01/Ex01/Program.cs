using Ex01.Entities;
using System;
using Ex01.Entities.Enums;


namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };
            
            Console.WriteLine(order);


            // convertendo enumerações para string
            string txt = OrderStatus.PendingPayment.ToString();

            // convertendo string para enumerações (precisa ter exatamente o mesmo nome de qualquer um dos valores do enum)
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}