﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class StandardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}