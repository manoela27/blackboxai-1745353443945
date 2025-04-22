using SupremoSchedulingSystem.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupremoSchedulingSystem.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task<Client?> GetClientByIdAsync(int id);
        Task AddClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientAsync(int id);
    }
}
