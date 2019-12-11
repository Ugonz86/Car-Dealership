using System;
using System.Collections.Generic;
using Dealership.Models;

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

            Console.WriteLine("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);

            Console.WriteLine("Enter maximum mileage: ");
            string stringMaxMileage = Console.ReadLine();
            int maxMileage = int.Parse(stringMaxMileage);

            List<Car> CarsMatchingSearch = new List<Car>(0);

            foreach (Car automobile in Cars)
            {
            if (automobile.WorthBuying(maxPrice, maxMileage))
            {
                CarsMatchingSearch.Add(automobile);
            }
            }
            if (CarsMatchingSearch.Count > 0) {
                foreach(Car automobile in CarsMatchingSearch)
                    {
                    Console.WriteLine(automobile.DisplayInfo());
                    }
            } else {
                Console.WriteLine("There is no cars matching the budget and mileage");
            }

        }
    }
}
