using System.Web.Mvc;
using API.Models;

namespace API.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View(new WeatherHelper());
        }
        [HttpPost]
        public ActionResult GetWeatherForecast(string InputCity)
        {
            WeatherHelper weather = new WeatherHelper();
            weather.InputCity = InputCity;
            return Json(weather.GetWeatherList(), JsonRequestBehavior.AllowGet);
        }
    }
}