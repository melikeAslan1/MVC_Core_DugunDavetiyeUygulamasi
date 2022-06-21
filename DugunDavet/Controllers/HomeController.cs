using DugunDavet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDavet.Controllers
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
            return View();
        }

        public ViewResult CevapFormu()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CevapFormu(Cevap KatilimciCevabi)
        {
            if(ModelState.IsValid)
            {
                Repository.cevaplar.Add(KatilimciCevabi);
                return View("Tesekkurler", KatilimciCevabi);
            }
            else
            {
                return View();
            }
           
        }

        public ViewResult CevaplariListele()
        {
            return View(Repository.cevaplar.Where(x => x.DuguneGelecekMi == true));
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
