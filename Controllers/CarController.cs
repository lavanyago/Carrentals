using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using carrentals.Models.Engine;
using carrentals.Models.Views;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace carrentals.Controllers
{

 [Authorize]
    public class CarController : Controller
    {
        public 
        private CarrentalsApp _carrentals;
        private UserManager<IdentityUser> _userManager;

         public CarController(CarrentalsApp carrental, UserManager<IdentityUser> userManager)
        {
            _carrentals = carrental;
            _userManager = userManager;

        }


        


          public IActionResult Index()
        {
            List<Hakucar> car = _carrentals.GetALL(UserId());
            return View(books);
        }

        public IActionResult Details(Guid id) {
            
            var book = _library.GetBook(id, UserId());

            return View(book);
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
