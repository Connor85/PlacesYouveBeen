using System.Collections.Generic;
using System.Collections;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _city;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city)
    {
      _city = city;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string input)
    {
      _city = input;
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
