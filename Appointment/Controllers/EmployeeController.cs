using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appointment.Models;
using Appointment_UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        public async ValueTask<ActionResult<IReadOnlyCollection<Employee>>> Index()
        {
            var users = await _service.GetAllCustomersAsync();
            return View(users);
        }
    }
}