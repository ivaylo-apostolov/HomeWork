using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Store
    {
        public string Name;
        public double Size;
        public Address Address;
        public List<Goods> Goods;
        public Owner Owner;
        public Seller Seller;

        public Store(string name, double size, Address address)
        {
            this.Name = name;
            this.Size = size;
            this.Address = address;
            this.Goods = new List<Goods>();
        }
    }
}
