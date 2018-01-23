using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace C_Sharp_WareHouse_Forms
{
    public static class SaveLoadtoFile
    {
        public static void SaveCustomerstoXml()
        {
            var list = Containers.GetCustomerList();
            XmlSerializer serialize = new XmlSerializer(typeof(List<Customer>));
            using (FileStream file = new FileStream("Customers.xml", FileMode.OpenOrCreate))
            {
                serialize.Serialize(file, list);
            }
        }

        public static void LoadCustomersFromXML()
        {
            if (!File.Exists(@"Customers.xml"))
                return;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamReader file = new StreamReader(@"Customers.xml"))
            {
                Containers.CustomerList = (List<Customer>)deserializer.Deserialize(file);
            }
        }

        public static void SaveProductstoXml()
        {
            var list = Containers.GetProductList();
            XmlSerializer serialize = new XmlSerializer(typeof(List<Product>));
            using (FileStream file = new FileStream("Products.xml", FileMode.OpenOrCreate))
            {
                serialize.Serialize(file, list);
            }
        }

        public static void LoadProductsFromXML()
        {
            if (!File.Exists(@"Products.xml"))
                return;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Product>));
            using (StreamReader file = new StreamReader(@"Products.xml"))
            {
                Containers.ProductList = (List<Product>)deserializer.Deserialize(file);
            }
        }


    }
}
