using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlace = new List<Place> {};
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
      Place newPlace = new Place(Request.Form["new-place"], Request.Form["new-state"]);
      newPlace.Save();
      List<Place> allPlaces = Place.GetAll();
      return View("Index", allPlaces);
    }
  }
}
