using DataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }
        public string License { get; set; }
        public string Phone { get; set; }
        public List<VehicleDTO> Vehicles { get; set; }

        public static UserViewModel FromUserDTO(UserDTO userDTO)
        {
            return new UserViewModel
            {
                Id = userDTO.Id,
                Name = userDTO.Name,
                Surname = userDTO.Surname,
                DNI = userDTO.DNI,
                License = userDTO.License,
                Phone = userDTO.Phone,
                Vehicles = userDTO.Vehicles,
            };
        }
    }
}
