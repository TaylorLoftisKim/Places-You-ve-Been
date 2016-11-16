using System.Collections.Generic;

namespace Places.Objects
{
  public class Place{
    private string _City;
    private static List<Place> _instances = new List<Place> {};

    public Place (string newCity)
    {
      _City = newCity;
    }

    public string GetCity()
    {
      return _City;
    }
    public void SetCity(string newCity)
    {
      _City = newCity;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
