using Microsoft.AspNetCore.Mvc;

namespace Doctor_Office.Controllers
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