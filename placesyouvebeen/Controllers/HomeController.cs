using Microsoft.AspNetCore.Mvc;

namespace PlacesYouveBeen.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
