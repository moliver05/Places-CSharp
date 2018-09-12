using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
public class CarsController : Controller
{

  [HttpGet("/cars")]
  public ActionResult Index()
  {
    List<Car> allCars = Car.GetAll();
    return View(allCars);

  }
  [HttpGet("/cars/new")]
  public ActionResult CreateForm()
  {
    return View();
  }

  [HttpPost("/cars")]
  public ActionResult Create()
  {
      Car newCar = new Car(Request.Form["car-make"], Request.Form["car-model"], Request.Form["car-price"], Request.Form["car-miles"], Request.Form["car-year"]);
      newCar.Save();
      List<Car> allCars = Car.GetAll();
      return View("Index", allCars);
  }
 }
}
