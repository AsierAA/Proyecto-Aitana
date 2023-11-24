using DataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }
        public int Category { get; set; }

        public UserViewModel User { get; set; } 

        public static VehicleViewModel FromVehicleDTO(VehicleDTO vehicleDTO)
        {
            return new VehicleViewModel
            {
                Id = vehicleDTO.Id,
                Brand = vehicleDTO.Brand,
                Model = vehicleDTO.Model,
                Engine = vehicleDTO.Engine,
                Category = vehicleDTO.Category,

                User = UserViewModel.FromUserDTO(vehicleDTO.User), 
            };
        }
    }
}
