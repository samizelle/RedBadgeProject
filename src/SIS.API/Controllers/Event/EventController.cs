﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RedStarter.API.Controllers.Event
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}