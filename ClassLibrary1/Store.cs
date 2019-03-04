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
        private List<Seller> Sellers;

        public Store(string name, double size, Address address)
        {
            this.Name = name;
            this.Size = size;
            this.Address = address;
            this.Goods = new List<Goods>();
            this.Sellers = new List<Seller>();
        }

        public void Hire(Seller seller)
        {
            this.Sellers.Add(seller);
        }

        public List<Seller> GetSellers()
        {
            return this.Sellers;
        }

        public bool IsInList(string name)
        {
            var result = false;

            foreach (var item in this.Sellers)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return result;
        }

        public void Fire(int age)
        {
            for (int i = 0; i < this.Sellers.Count; i++)
            {
                if (this.Sellers[i].Age > age)
                {
                    this.Sellers.Remove(this.Sellers[i]);
                    i--;
                }
            }
        }
    }
}
