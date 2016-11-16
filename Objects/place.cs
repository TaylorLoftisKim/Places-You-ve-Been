using System.Collections.Generic;

namespace Places.Objects
{
  public class Place{
    private string _City;
    private string _Photo;
    private string _Description;
    private static List<Place> _instances = new List<Place> {};

    public Place (string newCity, string newPhoto, string newDescription)
    {
      _City = newCity;
      _Photo = newPhoto;
      _Description = newDescription;
    }

    public string GetCity()
    {
      return _City;
    }
    public void SetCity(string newCity)
    {
      _City = newCity;
    }

    public string GetPhoto()
    {
      return _Photo;
    }
    public void SetPhoto(string newPhoto)
    {
      _Photo = newPhoto;
    }
    public string GetDescription()
    {
      return _Description;
    }
    public void SetDescription(string newDescription)
    {
      _Description = newDescription;
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
