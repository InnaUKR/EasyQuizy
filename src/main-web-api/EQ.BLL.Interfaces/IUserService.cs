using EQ.BLL.Models.ActionResults;
using EQ.BLL.Models.DTOs.User;
using EQ.Common.Models.Enums;
using EQ.DAL.Domain;
using System;
using System.Threading.Tasks;

namespace EQ.BLL.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(Guid userId);

        Task<User> GetUserBySecurityIdAsync(Guid securityId);

        Task<UserDetailsDto> GetUserDetailsBySecurityIdAsync(Guid securityId);

        UsersListPagedDto GetFiltered(string search, int skip, int take, string orderBy, OrderType orderType);

        Task<CreateUserResult> CreateUserAsync(CreateUserDto model, bool verifyEmail);

        Task<BaseResult> UpdateUserAsync(UpdateUserDto model);

        Task<BaseResult> ChangeUserEmailAsync(ChangeUserEmailUserIdDto model);

        Task<BaseResult> ChangeUserEmailAsync(ChangeUserEmailSecurityIdDto model);

        Task<BaseResult> ChangeStatusAsync(Guid userId, UserStatus status);

        bool IsAdminType(UserType userType);

        Task<bool> IsActiveBySecurityIdAsync(Guid securityId);
    }
}