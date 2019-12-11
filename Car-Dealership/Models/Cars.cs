using System;

namespace Dealership
{
  class Car
  {
    // Private properties. Get and set convert a public string into a private one. 
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Slogan { get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles, string slogan)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Slogan = slogan;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetSlogan()
    {
      return Slogan;
    }

    public static string MakeSound() //New method 
        {
            return "brrrruuummmm! ";
        }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
  }
}