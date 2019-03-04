using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Seller : Person
    {
        public Experience Experience;

        public Seller(string name, int age, Experience experience)
        {
            this.Name = name;
            this.Age = age;
            this.Experience = experience;
        }
    }
}
