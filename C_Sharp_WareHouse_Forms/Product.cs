﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_Sharp_WareHouse_Forms
{

    public class Product
    {
        public static int IDCounter = 0;
        public int UniqueID { get; set; }
        public string ArticleName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product() {}
        public Product(string name, decimal price, int quantity, string descrptn)
        {
            UniqueID = ++IDCounter;
            ArticleName = name;
            Price = price;
            Quantity = quantity;
            Description = descrptn;
        }

    }

    public class Customer
    {
        public static int IDCounter = 0;
        public int UniqueID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public Customer() {}
        public Customer(string name, string surname, string mail, string phone, string addr)
        {
            UniqueID = ++IDCounter;
            FirstName = name;
            LastName = surname;
            Email = mail;
            Contact = phone;
            Address = addr;
        }

        public void Update(string name, string surname, string email, string contact, string address)
        {
            FirstName = name;
            LastName = surname;
            Email = email;
            Contact = contact;
            Address = address;
        }
    }


    public class Order
    {
        public static int IDCounter = 0;
        public int UniqueID { get; set; }
        public Customer Client { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderedTime { get; set; }

        public Order() {}
        public Order(Customer client, Product prod, int quantity, DateTime date)
        {
            UniqueID = ++IDCounter;
            Client = client;
            Product = prod;
            Quantity = quantity;
            OrderedTime = date;
        }
    }

 
}
