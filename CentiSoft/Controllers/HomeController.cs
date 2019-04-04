using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CentiSoft.Models;
using CentiSoft.DAL.Entities;
using CentiSoft.DAL;

namespace CentiSoft.Controllers {
    public class HomeController : Controller {

        private readonly IRepository<Developer> developerRepository;

        public HomeController(IRepository<Developer> developerRepository) {
            this.developerRepository = developerRepository;
        }


        public IActionResult Index() {
            return View();
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Developer>> GetAll() {
        //    return developerRepository.GetAll();
        //}

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
