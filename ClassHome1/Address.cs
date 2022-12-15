using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHome1
{
    public class Address
    {
        public int index;
        public string country;
        public string city;
        public string street;
        public int building;
        public int house;

        

        public void Method()
        {
            Console.WriteLine($"Index: {index} \nCountry: {country} \nCity: {city} \nStreet: {street} \nBuilding: {building} \nHouse: {house}");
        }
    }
}
