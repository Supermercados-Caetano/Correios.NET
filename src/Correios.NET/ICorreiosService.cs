using System.Collections.Generic;
using System.Threading.Tasks;
using Correios.NET.Models;

namespace Correios.NET
{
    public interface ICorreiosService
    {
        Task<Package> GetPackageTrackingAsync(string packageCode);
        Package GetPackageTracking(string packageCode);

        Task<IEnumerable<Address>> GetAddressesAsync(string zipCode);
        Task<IEnumerable<Address>> GetAddressesAsync(params string?[] partes);
        IEnumerable<Address> GetAddresses(string zipCode);
        IEnumerable<Address> GetAddresses(params string?[] partes);
    }
}