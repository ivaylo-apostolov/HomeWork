using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Goods
    {
        public string Name;
        public double Price;
        public double Weight;
        public DateTime ExpDate;

        public Goods(string name, double price, double weight, int years, int months, int days)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
            this.ExpDate = new DateTime(years, months, days);
        }

        public override string ToString()
        {
            return this.Name + " " + this.Price + " " + this.Weight;
        }
    }
}
