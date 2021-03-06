﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AntoHelloAzure.Models;
using Microsoft.Extensions.Configuration;
    

namespace AntoHelloAzure.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        
        public HomeController(IConfiguration iconfig)
        {
            this.configuration = iconfig; 
        }

        public IActionResult Index()
        {
            var model = configuration["Greeting"];
            return View("Index" , model);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
