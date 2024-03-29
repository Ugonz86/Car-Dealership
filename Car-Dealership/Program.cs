using System;
using System.Collections.Generic;

namespace Dealership
{
    public class Program
    {
        public static void Main()
        {
            Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "People's car");
            Car yugo = new Car("1980 Yugo Koral", 700, 56000, "Buy a Littel Freedom");
            Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Go Further");
            Car amc = new Car("1976 AMC Pacer", 400, 198000, "The First Wide Small Car");

            List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

            // yugo.SetPrice(300); //This is optional. SetPrice is a C# method. Here it was used to change the value of a specific object.

            Console.WriteLine("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);

            Console.WriteLine("Enter maximum mileage: ");
            string stringMaxMileage = Console.ReadLine();
            int maxMileage = int.Parse(stringMaxMileage);

            List<Car> CarsMatchingSearch = new List<Car>(0);

            foreach (Car automobile in Cars)
            {
                if (automobile.WorthBuying(maxPrice))
                {
                    CarsMatchingSearch.Add(automobile);
                }
            }
            if (CarsMatchingSearch.Count > 0) {
                foreach(Car automobile in CarsMatchingSearch)
                    {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(automobile.GetMakeModel());
                    Console.WriteLine(automobile.GetMiles() + " miles");
                    Console.WriteLine("$" + automobile.GetPrice());
                    Console.WriteLine(automobile.GetSlogan());
                    Console.WriteLine(Car.MakeSound());
                    }
            } else {
                Console.WriteLine("There is no cars matching the budget and mileage");
            }

        }
    }
}
