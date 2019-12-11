using System;

namespace Dealership
{
  class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _slogan;


    public Car(string makeModel, int price, int miles, string slogan)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _slogan = slogan;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetSlogan()
    {
      return _slogan;
    }

    public static string MakeSound(string sound) //New method 
        {
            return "brrrruuummmm! " + sound;
        }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
  }
}