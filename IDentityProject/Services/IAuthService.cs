using IDentityProject.DTOs;
using IDentityProject.Models;

namespace IDentityProject.Services
{
    public interface IAuthService
    {
        public Task<AuthDTO> GenerateToken(AppUser user);
    }
}
