using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Product
    {
        public int ID;
        public string Name;
        public double Price;

        public Product(int id,string name,double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public void ChangeName()
        {
            Name = "SEO";
        }

        public void PercentCalculator()
        {
            Console.WriteLine(Price*0.18);
        }
    }
}
