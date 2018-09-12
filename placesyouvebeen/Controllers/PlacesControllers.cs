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
      Place newPlace = new Place(Request.Form["new-place"], Request.Form["new-state"], Request.Form["new-description"]);
      List<Place> allPlaces = Place.GetAll();
      return View("Index", allPlaces);
    }
    [HttpGet("places/{id}")]
    public ActionResult Details(int id)
    {
      Place city = Place.Find(id);
      return View(city);
    }
  }
}
