using FirstAPI.Models;
using FirstAPI.Models.DTOs;

namespace FirstAPI.Interfaces
{
    public interface IUserService
    {
        public User Login(UserDTO userDTO);
        public User Register(UserDTO userDTO);
    }
}
