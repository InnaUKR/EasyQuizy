using EQ.BLL.Interfaces;
using EQ.BLL.Models.ActionResults;
using EQ.BLL.Models.DTOs.User;
using EQ.Common.Models.Enums;
using EQ.DAL.Domain;
using EQ.DAL.Interfaces;
using EQ.Identity.Interfaces;
using System;
using System.Threading.Tasks;

namespace EQ.BLL.Implementation
{
    public class UserService : IUserService
    {
        private readonly IAuthService _authService;
        private readonly IUserRepository _userRepository;

        public UserService(IAuthService authService, IUserRepository userRepository)
        {
            _authService = authService;
            _userRepository = userRepository;
        }

        public async Task<BaseResult> ChangeStatusAsync(Guid userId, UserStatus status)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                return new BaseResult(false, "User not found");
            }

            var isBlocked = status == UserStatus.Deactivated ? true : false;

            var result = await _authService.ChangeBlockStateAsync(user.SecurityId, isBlocked);
            if (!result.IsSucceed)
            {
                return new BaseResult(false, result.ErrorMessage);
            }

            user.Status = status;
            await _userRepository.SaveChangesAsync();

            return new BaseResult(true);
        }

        public Task<BaseResult> ChangeUserEmailAsync(ChangeUserEmailUserIdDto model)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResult> ChangeUserEmailAsync(ChangeUserEmailSecurityIdDto model)
        {
            var user = await _userRepository.GetUserBySecurityIdAsync(model.UserSecuriryId);
            if (user == null)
            {
                return new BaseResult(false, "User not found");
            }

            try
            {
                if (await _authService.IsEmailExist(model.Email))
                {
                    return new BaseResult(false, "Email is already used");
                }

                var authResponse = await _authService.ChangeUserEmailAsync(model);
                if (!authResponse.IsSucceed)
                {
                    return new BaseResult(false, authResponse.ErrorMessage);
                }

                user.Email = model.Email;

                await _userRepository.SaveChangesAsync();
                
                return new BaseResult(true);
            }
            catch (Exception ex)
            {
                return new BaseResult(false, $"Failed to change user's email: {ex.Message}");
            }
        }

        public async Task<CreateUserResult> CreateUserAsync(CreateUserDto model, bool verifyEmail)
        {
            var authResponse = await _authService.CreateUserAsync(model, verifyEmail);
            if (!authResponse.IsSucceed)
            {
                return new CreateUserResult(false, authResponse.ErrorMessage);
            }

            var userId = Guid.NewGuid();

            try
            {
                _userRepository.Add(new User
                {
                    Id = Guid.NewGuid(),
                    SecurityId = authResponse.UserId,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Status = UserStatus.Active,
                    Type = model.Type
                });

                await _userRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await _authService.DeleteUserAsync(authResponse.UserId);

                return new CreateUserResult(false, "Failed to create an user");
            }

            return new CreateUserResult(true, userId);
        }

        public UsersListPagedDto GetFiltered(string search, int skip, int take, string orderBy, OrderType orderType)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(Guid userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<User> GetUserBySecurityIdAsync(Guid securityId)
        {
            return await _userRepository.GetUserBySecurityIdAsync(securityId);
        }

        public Task<UserDetailsDto> GetUserDetailsBySecurityIdAsync(Guid securityId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsActiveBySecurityIdAsync(Guid securityId)
        {
            var user = await _userRepository.GetUserBySecurityIdAsync(securityId);

            return user != null && user.Status != UserStatus.Deactivated;
        }

        public bool IsAdminType(UserType userType)
        {
            return userType == UserType.Admin;
        }

        public async Task<BaseResult> UpdateUserAsync(UpdateUserDto model)
        {
            var user = await _userRepository.GetByIdAsync(model.UserId);
            if (user == null)
            {
                return new BaseResult(false, "User not found");
            }

            try
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;

                await _userRepository.SaveChangesAsync();
                
                return new BaseResult(true);
            }
            catch (Exception ex)
            {
                return new BaseResult(false, $"Failed to update an user: {ex.Message}");
            }
        }
    }
}