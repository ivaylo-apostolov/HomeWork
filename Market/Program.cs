using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Kaufland", 550.35, new Address("Sofia", "Boris 3", "111", "1000"));
            Owner owner = new Owner("Ivan Ivanov", 41);
        
            Seller seller1 = new Seller("Petar", 23, new Experience(1, 1, 12));
            Seller seller2 = new Seller("Georgi", 55, new Experience(3, 2, 12));
            Seller seller3 = new Seller("Ivan", 62, new Experience(5, 3, 12));
            Seller seller4 = new Seller("Ivaylo", 35, new Experience(6, 4, 12));
            Seller seller5 = new Seller("Kalin", 48, new Experience(1, 5, 12));

            store.Hire(seller1);
            store.Hire(seller2);
            store.Hire(seller3);
            store.Hire(seller4);
            store.Hire(seller5);

            int count = store.GetSellers().Count;

            var isInList = store.IsInList("Petar");
            var isInList2 = store.IsInList("Toshko");
            store.Fire(50);

            Goods apples = new Goods("apples", 2.5, 1.5, 2019, 3, 27);
            Goods pears = new Goods("pears", 3.5, 2.5, 2019, 2, 27);
            Goods oranges = new Goods("oranges", 2.5, 1.5, 2019, 3, 17);

            store.Goods.Add(apples);
            store.Goods.Add(pears);
            store.Goods.Add(oranges);

            Console.WriteLine(store.Goods[0].ToString());            
        }
    }
}
