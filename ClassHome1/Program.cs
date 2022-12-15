using System;
using System.IO;
using System.Reflection;


namespace ClassHome1
{
    class Program
    {
        public static Address Karen()
        {
            Address karen = new Address();
            karen.index = 0096;
            karen.country = "Armenia";
            karen.city = "Yerevan";
            karen.street = "Moldovakan";
            karen.building = 2;
            karen.house = 1;

            return karen;
        }

        static void Main(string[] args)
        {
            var KarenAddress = Karen();

            KarenAddress.Method();
        }
    }
}
