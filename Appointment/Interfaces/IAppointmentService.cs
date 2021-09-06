using Appointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appointement_Services.Interfaces
{
    public interface IAppointmentService
    {
        ValueTask<Appointments> CreateAppointmentAsync(Appointments appointments);
        ValueTask<Appointments> RetrieveAppointmentByIdAsync(Expression<Func<Appointments, bool>> expression);
        ValueTask<Appointments> UpdateAppointmentAsync(Appointments appointments);
        ValueTask<IReadOnlyList<Appointments>> GetAppointmentsAsync();
        Task<int> MarkCompletedAppointment(int id);
    }
}
