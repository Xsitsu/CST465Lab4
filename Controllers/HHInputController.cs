﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Lab4.Models;

namespace Lab4.Controllers
{
    public class HHInputController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(ComputerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            return View(model);
        }
    }
}