﻿using Microsoft.AspNetCore.Mvc;
using MVCuppgift.Models;

namespace MVCuppgift.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult Fevercheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fevercheck(string temperature)
        {
            FeverModel.Temperature = temperature;
            return View();
        }


    }
}