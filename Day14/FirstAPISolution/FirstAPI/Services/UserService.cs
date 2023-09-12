using FirstAPI.Interfaces;
using FirstAPI.Models;
using FirstAPI.Models.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace FirstAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<string, User> _userRepository;

        public UserService(IRepository<string,User> repository) 
        { 
            _userRepository = repository;
        }
        public User Login(UserDTO userDTO)
        {
            var user = _userRepository.Get(userDTO.Username);
            if(user != null)
            {
                var dbPass = user.Password;
                HMACSHA512 hMACSHA512 = new HMACSHA512(user.Key);
                var userPass = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                if(userPass.Length==dbPass.Length)
                {
                    for(int i = 0; i < dbPass.Length; i++)
                    {
                        if (userPass[i] != dbPass[i])
                            return null;
                    }
                    user.Password = null;
                    user.Key = null;
                    return user;
                }
            }
            return null;
        }

        public User Register(UserDTO userDTO)
        {
            HMACSHA512 hMACSHA512 = new HMACSHA512();
            User user = new User();
            user.Username = userDTO.Username;
            user.Password = hMACSHA512.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
            user.Key = hMACSHA512.Key;
            _userRepository.Add(user);
            return user;
        }
    }
}
