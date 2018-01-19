﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_WareHouse_Forms
{
    public class Product
    {
        public string ArticleName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product() {}
        public Product(string name, decimal price, int quantity, string descrptn)
        {
            ArticleName = name;
            Price = price;
            Quantity = quantity;
            Description = descrptn;
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public Customer() {}
        public Customer(string name, string surname, string mail, string phone, string addr)
        {
            FirstName = name;
            LastName = surname;
            Email = mail;
            Contact = phone;
            Address = addr;
        }
    }

    public class Order
    {
        public Customer Client { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderedTime { get; set; }
        public Order() {}
        public Order(Customer client, Product prod, int quantity, DateTime date)
        {
            Client = client;
            Product = prod;
            Quantity = quantity;
            OrderedTime = date;
        }
    }

 
}
