using EQ.BLL.Models.DTOs.User;
using EQ.Identity.Models;
using EQ.Identity.Models.Response;
using System;
using System.Threading.Tasks;

namespace EQ.Identity.Interfaces
{
    public interface IAuthService
    {
        Task<IdentityUser> GetUserByIdAsync(string userId);

        Task<bool> IsEmailExist(string email);

        Task<TokenResponse> LoginAsync(string username, string password);

        Task<ResetPasswordResponse> ResetPasswordAsync(string email);

        Task<CreateUserResponse> CreateUserAsync(CreateUserDto user, bool verifyEmail);

        Task<ChangeUserEmailResponse> ChangeUserEmailAsync(ChangeUserEmailSecurityIdDto user);

        Task<BlockUserResponse> ChangeBlockStateAsync(Guid userId, bool isBlocked);

        Task DeleteUserAsync(Guid userId);
    }
}