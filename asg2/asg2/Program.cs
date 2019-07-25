using System;

namespace asg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart c = new Cart();
            do
            {
              int choose;
                Console.WriteLine("Choose:");
                Console.WriteLine("1| Add product.");
                Console.WriteLine("2| Remove product.");
                Console.WriteLine("3| Show cart.");
                Console.WriteLine("4| Exit.");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        c.AddProduct();
                        Cart ca = new Cart(c.Id, c.Customer, c.City, c.Country, c.Total);
                        break;
                    case 2:
                        c.RemoveProduct();
                       break;
                    case 3:
                        c.ShowCart();
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
            } while (true);
        }
    }
}