using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Sofia", "Boris 3", "111", "1000");
            Store store = new Store("Kaufland", 550.35, address);

            Owner owner = new Owner("Ivan Ivanov", 41);

            Experience experience = new Experience(2, 11, 27);
            Seller seller1 = new Seller("Petar Petrov", 23, experience);

            Goods apples = new Goods("apples", 2.5, 1.5, 2019, 3, 27);
            Goods pears = new Goods("pears", 3.5, 2.5, 2019, 2, 27);
            Goods oranges = new Goods("oranges", 2.5, 1.5, 2019, 3, 17);

            store.Goods.Add(apples);
            store.Goods.Add(pears);
            store.Goods.Add(oranges);
        }
    }
}
