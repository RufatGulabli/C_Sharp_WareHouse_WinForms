using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_WareHouse_Forms
{
    public static class Containers
    {
        public static List<Product> ProductList = new List<Product>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Order> OrderList = new List<Order>();

        public static void CreateProduct(string articleName, decimal price, int quantity, string desc)
        {
            Product prod = new Product(articleName,price,quantity,desc);
            ProductList.Add(prod);
            return;
        }

        public static void CreateCustomer(string firstName, string lastName, string email, string contact, string address)
        {
            Customer customer = new Customer(firstName, lastName, email, contact, address);
            CustomerList.Add(customer);
            return;
        }

        public static void CreateOrder(Customer customer, Product prod, int quantity, DateTime date)
        {
            Order newOrder = new Order(customer, prod, quantity, date);
            OrderList.Add(newOrder);
            return;
        }
    }

}
