using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appointment.Models;
using Appointment_UI.AppContext;
using Appointment_UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_UI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var users = _service.GetAllCustomersAsync();
            return View(users);
        }
    }
}
