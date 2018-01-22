﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_WareHouse_Forms
{
    public class Containers
    {
        
        public static List<Product> ProductList = new List<Product>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Order> OrderList = new List<Order>();
        public delegate void GridViewUpdate();
        public event GridViewUpdate ListUpdate;

        public void AddCustomer(Customer cust)
        {
            CustomerList.Add(cust);
            ListUpdate?.Invoke();
        }

        public void DeleteCustomer(int id)
        {
            CustomerList.RemoveAll(x => x.UniqueID == id);
            ListUpdate?.Invoke();
        }

        public void AddProduct(Product product)
        {
            ProductList.Add(product);
            ListUpdate?.Invoke();
        }

        public void DeleteProduct(int id)
        {
            ProductList.RemoveAll(x => x.UniqueID == id);
            ListUpdate?.Invoke();
        }

        public void AddOrder(Order order)
        {
            OrderList.Add(order);
            ListUpdate?.Invoke();
        }

        public void DeleteOrder(int id)
        {
            OrderList.RemoveAll(x => x.UniqueID == id);
            ListUpdate?.Invoke();
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

        public void UpdateCustomer(int index, string name, string surname, string email,
            string phone, string address)
        {
            if (index < 0) return;
            Customer customer = CustomerList.Find(item => item.UniqueID == index);
            customer.Update(name, surname, email, phone, address);
            ListUpdate?.Invoke();
            return;
        }

 
    }

}
