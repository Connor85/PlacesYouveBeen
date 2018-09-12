using System.Collections.Generic;
using System.Collections;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _city;
    private string _state;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city, string state)
    {
      _city = city;
      _state = state;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string input)
    {
      _city = input;
    }
    public string GetState()
    {
      return _state.ToUpper();
    }
    public void SetState(string state)
    {
      _state = state;
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
