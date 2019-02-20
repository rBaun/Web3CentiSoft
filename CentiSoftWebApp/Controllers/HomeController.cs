﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CentiSoftWebApp.Models;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;

namespace CentiSoftWebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IConfiguration config)
        {
            Client.configuration = config;
        }

        public IActionResult Index(int id)
        {
            Client.GetClient(id);
            ClientViewModel client = new ClientViewModel();
            client.Id = Client.Id;
            client.Name = Client.Name;
            client.Token = Client.Token;

            return View(client);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
