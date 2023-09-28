using DILifeTimesExample.Models;
using DILifeTimesExample.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DILifeTimesExample.Controllers
{
    public class HomeController(ILogger<HomeController> logger, ISingletonService singletonService, IScopedService scopedService, ITransientService transientService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly ISingletonService _singletonService = singletonService;
        private readonly IScopedService _scopedService = scopedService;
        private readonly ITransientService _transientService = transientService;

        public IActionResult Index()
        {
            var lifeTimeModel = new LifeTimeModel() { 
                SingletonTime = _singletonService.Time,
                ScopedTime = _scopedService.Time,
                TransientTime = _transientService.Time,
            };
            return View(lifeTimeModel);
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
    }
}
