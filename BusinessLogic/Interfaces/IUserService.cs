using DataModels;
using DataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(int userId);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task CreateUserAsync(UserDTO user);
        Task UpdateUserAsync(int userId, UserDTO user);
        Task DeleteUserAsync(int userId);
    }
}
