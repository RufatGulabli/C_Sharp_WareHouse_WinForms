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

        public static List<Product> GetProductList() => ProductList;
        public static List<Customer> GetCustomerList() => CustomerList;
        public static List<Order> GetOrderList() => OrderList;

        public static int GetLastCustomerID()
        {
            if (CustomerList.Count == 0)
                return 0;
            else
            {
                int i = CustomerList[CustomerList.Count - 1].UniqueID;
                return i;
            }
        }

        public static int GetLastProductID()
        {
            if (ProductList.Count == 0)
                return 0;
            else
            {
                int i = ProductList[ProductList.Count - 1].UniqueID;
                return i;
            }
        }

        public static int GetLastOrderID()
        {
            if (OrderList.Count == 0)
                return 0;
            else
            {
                int i = OrderList[OrderList.Count - 1].UniqueID;
                return i;
            }
        }

        public static void DeleteCustomer(int id)
        {
            Customer customer = CustomerList.Find(item => item.UniqueID == id);
            CustomerList.Remove(customer);
        }

        public static void UpdateCustomer(int index, string name, string surname, string email,
            string phone, string address)
        {
            Customer customer = CustomerList.Find(item => item.UniqueID == index);
            customer.Update(name, surname, email, phone, address);
            return;
        }
    }

}
