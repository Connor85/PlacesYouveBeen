using System.Collections.Generic;
using System.Collections;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _city;
    private string _state;
    private string _description;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city, string state, string description)
    {
      _city = city;
      _state = state;
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
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
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string description)
    {
      _description = description;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
