using Microsoft.AspNetCore.Mvc;

namespace TreatsList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}