using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Appointment.Models;
using Appointment_UI.AppContext;
using Appointement_Services.Services;
using Appointement_Services.Interfaces;

namespace Appointment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAppointmentService _service;

        public HomeController(ILogger<HomeController> logger, IAppointmentService service)
        {
            _logger = logger;
            _service = service;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<Appointments>> GetAppointment(int id)
        {
            var appointment = await _service.RetrieveAppointmentByIdAsync(x => x.Id == id);

            if (appointment is null)
            {
                return NotFound();
            }
            return appointment;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
