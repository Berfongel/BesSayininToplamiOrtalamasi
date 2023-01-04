using BesSayininToplamiCapimiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BesSayininToplamiCapimiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(BesSayininToplamiCapimi besSayininToplamiCapimi)
        {
            var sayi1 = besSayininToplamiCapimi.Sayi1;
            var sayi2 = besSayininToplamiCapimi.Sayi2;

            var sayi3 = besSayininToplamiCapimi.Sayi3;
            var sayi4 = besSayininToplamiCapimi.Sayi4;

            var sayi5 = besSayininToplamiCapimi.Sayi5;
            var toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;
            var ortalama = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5;

            var messegaToplam = string.Empty;
            var messegaOrtalama = string.Empty;
            messegaToplam =" Girilen sayıların toplamı : " + toplam;
            messegaOrtalama = " Girilen sayıların ortalaması : " + ortalama;

            ViewBag.MessageToplam = messegaToplam;
            ViewBag.MessageOrtalama = messegaOrtalama;

            return View("besSayininToplamiCapimi");
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