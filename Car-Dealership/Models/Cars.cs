namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel;
    public int Price;
    public int Miles;
    public string Slogan;

    public Car(string makeModel, int price, int miles, string slogan)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Slogan = slogan;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price < maxPrice && Miles < maxMileage);
    }

    public string DisplayInfo() {
        return MakeModel + " / Price: " + Price + " / " + Miles + " miles / Slogan: " + Slogan;
    }
  }
}