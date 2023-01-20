using BikeStation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using BikeStation.Services;
using BikeStation.DataSource;

namespace BikeStation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = DataSourceModels.StationsModel;
            return View(model);
        }

        public IActionResult Graphic()
        {
            var model = GraphicHelper.GetNumberOfBikesAtStations();
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Search()
        {
            var model = DataSourceModels.StationsModel;
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AddBike(BikeModel model)
        {
            var filePath= @"./DataSource/bike.json";
            JsonHelper.AddBikeToJsonFile(model, filePath);
            return Ok();
        }
        [HttpPost]
        public IActionResult SearchBike(BikeModel model)
        {
            var list = SearchBikes.SearchBikesByBikeModel(model);
            return Json(list);
        }
    }
}
