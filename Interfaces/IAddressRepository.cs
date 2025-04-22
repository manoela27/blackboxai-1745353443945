using SupremoSchedulingSystem.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupremoSchedulingSystem.Interfaces
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAddressesByClientIdAsync(int clientId);
        Task<Address?> GetAddressByIdAsync(int id);
        Task AddAddressAsync(Address address);
        Task UpdateAddressAsync(Address address);
        Task DeleteAddressAsync(int id);
    }
}
