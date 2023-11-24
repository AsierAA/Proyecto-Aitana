using DataAccess.Repository;
using DataModels;
using DataModels.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllWithIncludedAsync(u => u.Vehicles);
            return users.Select(user => UserDTO.FromUser(user));
        }

        public async Task<UserDTO> GetUserByIdAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return user != null ? UserDTO.FromUser(user) : null;
        }

        public async Task CreateUserAsync(UserDTO userDTO)
        {
            var newUser = new User
            {
                Id = userDTO.Id,
                Name = userDTO.Name,
                Surname = userDTO.Surname,
                DNI = userDTO.DNI,
                License = userDTO.License,
                Phone = userDTO.Phone
            };

            await _userRepository.AddAsync(newUser);
        }

        public async Task UpdateUserAsync(int userId, UserDTO userDTO)
        {
            var existingUser = await _userRepository.GetByIdAsync(userId);

            if (existingUser != null)
            {
                existingUser.Name = userDTO.Name;
                existingUser.Surname = userDTO.Surname;
                existingUser.DNI = userDTO.DNI;
                existingUser.License = userDTO.License;
                existingUser.Phone = userDTO.Phone;

                await _userRepository.UpdateAsync(existingUser);
            }
        }

        public async Task DeleteUserAsync(int userId)
        {
            var userToDelete = await _userRepository.GetByIdAsync(userId);

            if (userToDelete != null)
            {
                await _userRepository.DeleteAsync(userToDelete);
            }
        }
    }
}
