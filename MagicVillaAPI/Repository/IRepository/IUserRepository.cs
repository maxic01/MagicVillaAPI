using MagicVillaAPI.Models;
using MagicVillaAPI.Models.DTO;

namespace MagicVillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
