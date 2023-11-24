using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }
        public string License { get; set; }
        public string Phone { get; set; }

        public List<VehicleDTO> Vehicles { get; set; }

        public static UserDTO FromUser(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                DNI = user.DNI,
                License = user.License,
                Phone = user.Phone,
                Vehicles = user.Vehicles?.Select(v => VehicleDTO.FromVehicle(v)).ToList()
            };
        }
    }
}
