﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_UI.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}