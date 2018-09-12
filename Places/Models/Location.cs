using System.Collections.Generic;
using System.Collections;

namespace CarDealership.Models
{
  public class Car
  {
    private string _carMake;
    private string _carModel;
    private string _carPrice;
    private string _carMiles;
    private string _carYear;
    private static List<Car> _instances = new List<Car> (){};

    public Car (string carMake, string carModel, string carPrice, string carMiles, string carYear)
    {
      _carMake = carMake;
      _carModel = carModel;
      _carPrice = carPrice;
      _carMiles = carMiles;
      _carYear = carYear;

    }
    public string GetCarMake()
    {
      return _carMake;
    }
    public void SetCarMake(string newcarMake)
    {
      _carMake = newcarMake;
    }

    public string GetModel()
    {
      return _carModel;
    }
    public void SetModel(string newcarModel)
    {
      _carModel = newcarModel;
    }

    public string GetPrice()
    {
      return _carPrice;
    }
    public void SetPrice(string newcarPrice)
    {
      _carPrice = newcarPrice;
    }

    public string GetMiles()
    {
      return _carMiles;
    }
    public void SetMiles(string newcarMiles)
    {
      _carMiles = newcarMiles;
    }

    public string GetYear()
    {
      return _carYear;
    }
    public void SetYear(string newcarYear)
    {
      _carYear = newcarYear;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
   }
  }



// public class Program
// {
//   public static void Main()
//   {
//     Car porsche = new Car();
//     porsche.MakeModel = "2014 Porsche 911";
//     porsche.Price = 114991;
//     porsche.Miles = 7864;
//     porsche.Type = "Sport";
//
//     Car ford = new Car();
//     ford.MakeModel = "2011 Ford F450";
//     ford.Price = 55995;
//     ford.Miles = 14241;
//     ford.Type = "Truck";
//
//     Car lexus = new Car();
//     lexus.MakeModel = "2013 Lexus RX 350";
//     lexus.Price = 44700;
//     lexus.Miles = 20000;
//     lexus.Type = "Luxury";
//
//     Car mercedes = new Car();
//     mercedes.MakeModel = "Mercedes Benz CLS550";
//     mercedes.Price = 39900;
//     mercedes.Miles = 37979;
//     mercedes.Type = "Luxury";

    // List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    //
    // Console.WriteLine("Enter maximum price: ");
    // string stringMaxPrice = Console.ReadLine();
    // string maxPrice = int.Parse(stringMaxPrice);
    //
    //
    // Console.WriteLine("Enter maximum miles: ");
    // string stringMaxMiles = Console.ReadLine();
    // int maxMiles = int.Parse(stringMaxMiles);
    //
    // Console.WriteLine("Choose car type: ");
    // string stringcarType = Console.ReadLine();
    // string carType = (stringcarType);
    // List<Car> CarsMatchingSearch = new List<Car>(0);

//   foreach (Car automobile in Cars)
// {
//   if (automobile.WorthBuying(maxPrice, maxMiles, carType))
//   {
//     CarsMatchingSearch.Add(automobile);
//   }
// }
//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }
