using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tourism.Models;

namespace Tourism.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Hotel()
        {
            return View();
        }

        public IActionResult otp()
        {
            return View();
        }

        public IActionResult thanks()
        {
            return View();
        }

        public IActionResult Journey()
        {
            return View();
        }

        public IActionResult pay()
        {
            return View();
        }

        public IActionResult ArunachalPradesh()
        {
            return View();
        }

        public IActionResult Assam()
        {
            return View();
        }

        public IActionResult Bihar()
        {
            return View();
        }

        public IActionResult Chandigarh()
        {
            return View();
        }

        public IActionResult Chhattisgarh()
        {
            return View();
        }

        public IActionResult Delhi()
        {
            return View();
        }

        public IActionResult DadraAndNagarHaveliAndDamanAndDiu()
        {
            return View();
        }

        public IActionResult Goa()
        {
            return View();
        }

        public IActionResult Gujarat()
        {
            return View();
        }

        public IActionResult Harayana()
        {
            return View();
        }

        public IActionResult HimachalPradesh()
        {
            return View();
        }

        public IActionResult JammuAndKashmir()
        {
            return View();
        }

        public IActionResult Jharkhand()
        {
            return View();
        }

        public IActionResult Karnataka()
        {
            return View();
        }

        public IActionResult Kerala()
        {
            return View();
        }

        public IActionResult Ladakh()
        {
            return View();
        }

        public IActionResult Lakshwadeep()
        {
            return View();
        }

        public IActionResult MadhyaPradesh()
        {
            return View();
        }

        public IActionResult Maharashtra()
        {
            return View();
        }

        public IActionResult Manipur()
        {
            return View();
        }

        public IActionResult Meghalaya()
        {
            return View();
        }

        public IActionResult Mizoram()
        {
            return View();
        }

        public IActionResult Nagaland()
        {
            return View();
        }

        public IActionResult Odisha()
        {
            return View();
        }

        public IActionResult Puducherry()
        {
            return View();
        }


        public IActionResult Punjab()
        {
            return View();
        }


        public IActionResult Rajasthan()
        {
            return View();
        }


        public IActionResult Sikkim()
        {
            return View();
        }


        public IActionResult TamilNadu()
        {
            return View();
        }

        public IActionResult Telangana()
        {
            return View();
        }

        public IActionResult Tripura()
        {
            return View();
        }


        public IActionResult Uttarakhand()
        {
            return View();
        }


        public IActionResult UttarPradesh()
        {
            return View();
        }

        public IActionResult WestBengal()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult paymentform()
        {
            return View();
        }
        public IActionResult CookieConsent()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult AndamanAndNicobarIslands()
        {
            return View();
        }

        public IActionResult AndhraPradesh()
        {
            return View();
        }

        public IActionResult TermsConditions()
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
