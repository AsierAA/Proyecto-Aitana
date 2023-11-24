using DataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IVehicleService
    {
        Task<VehicleDTO> GetVehicleByIdAsync(int vehicleId);
        Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync();
        Task CreateVehicleAsync(VehicleDTO vehicle);
        Task UpdateVehicleAsync(int vehicleId, VehicleDTO vehicle);
        Task DeleteVehicleAsync(int vehicleId);
    }
}
