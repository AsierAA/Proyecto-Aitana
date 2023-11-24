using DataAccess.Repository;
using DataModels;
using DataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository<Vehicle> _vehicleRepository;

        public VehicleService(IRepository<Vehicle> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<IEnumerable<VehicleDTO>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return vehicles.Select(vehicle => VehicleDTO.FromVehicle(vehicle));
        }

        public async Task<VehicleDTO> GetVehicleByIdAsync(int vehicleId)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(vehicleId);
            return vehicle != null ? VehicleDTO.FromVehicle(vehicle) : null;
        }

        public async Task CreateVehicleAsync(VehicleDTO vehicleDTO)
        {
            var newVehicle = new Vehicle
            {
                Id = vehicleDTO.Id,
                Brand = vehicleDTO.Brand,
                Model = vehicleDTO.Model,
                Engine = vehicleDTO.Engine,
                Category = vehicleDTO.Category
            };

            await _vehicleRepository.AddAsync(newVehicle);
        }

        public async Task UpdateVehicleAsync(int vehicleId, VehicleDTO vehicleDTO)
        {
            var existingVehicle = await _vehicleRepository.GetByIdAsync(vehicleId);

            if (existingVehicle != null)
            {
                existingVehicle.Brand = vehicleDTO.Brand;
                existingVehicle.Model = vehicleDTO.Model;
                existingVehicle.Engine = vehicleDTO.Engine;
                existingVehicle.Category = vehicleDTO.Category;

                await _vehicleRepository.UpdateAsync(existingVehicle);
            }
            else
            {

            }
        }

        public async Task DeleteVehicleAsync(int vehicleId)
        {
            var vehicleToDelete = await _vehicleRepository.GetByIdAsync(vehicleId);

            if (vehicleToDelete != null)
            {
                await _vehicleRepository.DeleteAsync(vehicleToDelete);
            }
        }
    }
}
