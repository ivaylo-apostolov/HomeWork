using System;

namespace ClassLibrary1
{
    public class Address
    {
        public string City;
        public string Street;
        public string Number;
        public string Postecode;

        public Address(string city, string street, string number, string postecode)
        {
            this.City = city;
            this.Street = street;
            this.Number = number;
            this.Postecode = postecode;
        }
    }
}
