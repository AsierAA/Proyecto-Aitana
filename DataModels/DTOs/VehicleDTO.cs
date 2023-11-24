using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DTOs
{
    public class VehicleDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }
        public int Category { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }

        public static VehicleDTO FromVehicle(Vehicle vehicle)
        {
            return new VehicleDTO
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                Engine = vehicle.Engine,
                Category = vehicle.Category,
                UserId = vehicle.UserId,
            };
        }
    }
}
