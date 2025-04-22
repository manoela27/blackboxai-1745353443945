using SupremoSchedulingSystem.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupremoSchedulingSystem.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetAppointmentsByClientIdAsync(int clientId);
        Task<IEnumerable<Appointment>> GetAppointmentsByEmployeeIdAsync(int employeeId);
        Task<Appointment?> GetAppointmentByIdAsync(int id);
        Task AddAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(int id);
    }
}
