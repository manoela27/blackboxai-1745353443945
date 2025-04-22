using Microsoft.EntityFrameworkCore;
using SupremoSchedulingSystem.Entities;
using SupremoSchedulingSystem.Interfaces;
using SupremoSchedulingSystem.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SupremoSchedulingSystem.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByClientIdAsync(int clientId)
        {
            return await _context.Appointments
                .Where(a => a.ClientId == clientId)
                .Include(a => a.Employee)
                .ToListAsync();
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByEmployeeIdAsync(int employeeId)
        {
            return await _context.Appointments
                .Where(a => a.EmployeeId == employeeId)
                .Include(a => a.Client)
                .ToListAsync();
        }

        public async Task<Appointment?> GetAppointmentByIdAsync(int id)
        {
            return await _context.Appointments
                .Include(a => a.Client)
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
