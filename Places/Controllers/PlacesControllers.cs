using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Places.Models;

namespace Places.Controllers
{
public class PlaceController : Controller
{

  [HttpGet("/places")]
  public ActionResult Index()
  {
    List<Place> allPlace = Place.GetAll();
    return View(allPlace);

  }

  [HttpGet("/places/new")]
  public ActionResult CreateForm()
  {
    return View();
  }

  [HttpPost("/places")]
  public ActionResult Create()
  {
      Place newPlace = new Place(Request.Form["city-name"], Request.Form["city-info"], Request.Form["city-image"]);
      List<Place> allPlace = Place.GetAll();
      return View("Index", allPlace);
  }
  [HttpPost("places/delete")]
  public ActionResult DeleteAll()

  {
    Place.ClearAll();
    return View();
  }

  [HttpGet("/places/{id}")]
    public ActionResult Details(int id)
    {
      Place place = Place.Find(id);
      return View(place);

    }
 }
}
