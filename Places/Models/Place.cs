using System.Collections.Generic;
using System.Collections;

namespace Places.Models
{
  public class Place
  {
    private string _cityName;
    private string _cityInfo;
    private string _image;
    private int _id;
    private static List<Place> _instances = new List<Place>{};

    public Place (string cityName, string cityInfo, string cityImage)
    {
      _cityName = cityName;
      _cityInfo = cityInfo;
      _image = cityImage;

      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string newcityName)
    {
      _cityName = newcityName;
    }

    public string GetCityInfo()
    {
      return _cityInfo;
    }

    public void SetCityInfo(string newcityInfo)
    {
      _cityInfo = newcityInfo;
    }
    public string GetCityImage()
    {
      return _image;
    }
    public void SetCityImage(string newcityImage)
    {
      _image = newcityImage;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
   }
  }
