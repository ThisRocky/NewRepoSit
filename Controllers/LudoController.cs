﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LudoBrowser.Controllers
{
    public class LudoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}