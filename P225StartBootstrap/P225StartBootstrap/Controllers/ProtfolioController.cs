﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225StartBootstrap.Controllers
{
    public class ProtfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}