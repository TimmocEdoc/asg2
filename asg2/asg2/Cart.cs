using System;
using System.Collections.Generic;

namespace asg2
{
    public class Cart
    {
        public int Id;
        public string Customer;
        public List<int> GrandTotal = new List<int>();
        public List<string> ProductList = new List<string>();
        public string City;
        public string Country;
        public int Total;
        public string listElement;
        public int price;
        public Cart()
        {
            
        }
        public Cart(int id, string customer, string city, string country, int total)
        {
            Id = id;
            Customer = customer;
            City = city;
            Country = country;
            Total = total;
        }
        public void AddProduct()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("Add id:");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add customer:");
                Customer = Console.ReadLine();
                Console.WriteLine("Add city:");
                City = Console.ReadLine();
                Console.WriteLine("Add country:");
                Country = Console.ReadLine();
                Console.WriteLine("Add product:");
                listElement = Console.ReadLine();
                Console.WriteLine("Add price:");
                price = Convert.ToInt32(Console.ReadLine());
                ProductList.Add(listElement);
                GrandTotal.Add(price);
            }
            else
            {
                Console.WriteLine("Add product:");
                listElement = Console.ReadLine();
                int i = 0;
                foreach (string n in ProductList)
                {
                    if (listElement == n)
                    {
                        ProductList.Add(listElement);
                        GrandTotal.Add(GrandTotal[i]);
                        return;
                    }
                    i++;
                }
                Console.WriteLine("Add price:");
                price = Convert.ToInt32(Console.ReadLine());
                ProductList.Add(listElement);
                GrandTotal.Add(price);
            }
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Enter product name:");
            String Product = Console.ReadLine();
            int i = 0;
            foreach (string n in ProductList)
            {
                if (Product == n)
                {
                    ProductList.RemoveAt(i);
                    GrandTotal.RemoveAt(i);
                    Console.WriteLine("success!");
                    return;
                }
                i++;
            }
            Console.WriteLine("There's no such things.");
        }

        public void ShowCart()
        {
            double grandTotal = 0;
            foreach (int price in GrandTotal)
            {
                grandTotal = price + grandTotal;
            }
            if (City == "Ha Noi" || City == "HCM")
            {
                grandTotal = (grandTotal / 100 * 1) + grandTotal;
            }
            else if(Country == "Viet Nam")
            {
                grandTotal = (grandTotal / 100 * 2) + grandTotal;
            }
            else
            {
                grandTotal = (grandTotal / 100 * 5) + grandTotal;
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Id:"+Id);
            Console.WriteLine("Customer:"+Customer);
            Console.WriteLine("Item list:");
            int i = 0;
            foreach (String n in ProductList)
            {
                Console.WriteLine("---Item: "+n+" (price: "+GrandTotal[i]+")");
                i++;
            }
            Console.WriteLine("City:"+City);
            Console.WriteLine("Country:"+Country);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Total:"+grandTotal);
            Console.WriteLine("----------------------------");
        }
    }
}