using Auth0.AuthenticationApi;
using Auth0.AuthenticationApi.Models;
using Auth0.ManagementApi;
using Auth0.ManagementApi.Models;
using AutoMapper;
using EQ.BLL.Models.DTOs.User;
using EQ.Identity.Implementation.Auth0.Configuration;
using EQ.Identity.Interfaces;
using EQ.Identity.Models;
using EQ.Identity.Models.Response;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EQ.Identity.Implementation.Auth0
{
    public class Auth0Service : IAuthService  
    {
        private readonly IManagementApiClient _managementApiClient;
        private readonly IAuthenticationApiClient _authenticationApiClient;
        private readonly Auth0Configuration.Client _authConfig;

        public Auth0Service(IManagementApiClient managementApiClient, IAuthenticationApiClient authenticationApiClient, IOptions<Auth0Configuration> authConfig)
        {
            _managementApiClient = managementApiClient;
            _authenticationApiClient = authenticationApiClient;
            _authConfig = authConfig.Value.Clients.FirstOrDefault(x => x.ClientName == "eazyquizy");
        }

        public async Task<BlockUserResponse> ChangeBlockStateAsync(string userId, bool isBlocked)
        {
            var response = new BlockUserResponse();
            try
            {
                await _managementApiClient.Users.UpdateAsync(userId, new UserUpdateRequest
                {
                    Blocked = isBlocked
                });
            }
            catch (Exception ex)
            {
                response.IsSucceed = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public Task<BlockUserResponse> ChangeBlockStateAsync(Guid userId, bool isBlocked)
        {
            throw new NotImplementedException();
        }

        public async Task<ChangeUserEmailResponse> ChangeUserEmailAsync(ChangeUserEmailSecurityIdDto user)
        {
            var response = new ChangeUserEmailResponse();

            try
            {
                await _managementApiClient.Users.UpdateAsync(user.UserSecuriryId.ToString(), new UserUpdateRequest
                {
                    VerifyEmail = true,
                    Email = user.Email,
                });
            }
            catch (Exception ex)
            {
                response.IsSucceed = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserDto user, bool verifyEmail)
        {
            var response = new CreateUserResponse();

            try
            {
                var auth0Response = await _managementApiClient.Users.CreateAsync(new UserCreateRequest
                {
                    Connection = _authConfig.Connection,
                    Email = user.Email,
                    NickName = user.Email,
                    FullName = $"{user.FirstName} {user.LastName}",
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    VerifyEmail = verifyEmail,
                    EmailVerified = !verifyEmail,
                    AppMetadata = new
                    {
                        roles = new[] { user.Type.ToString().ToLower() }
                    }
                });

                response = Mapper.Map<CreateUserResponse>(auth0Response);
            }
            catch (Exception ex)
            {
                response.IsSucceed = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            await _managementApiClient.Users.DeleteAsync(userId.ToString());
        }

        public async Task<IdentityUser> GetUserByIdAsync(string userId)
        {
            var auth0Response = await _managementApiClient.Users.GetAsync(userId);

            return Mapper.Map<IdentityUser>(auth0Response);
        }

        public async Task<bool> IsEmailExist(string email)
        {
            var users = await _managementApiClient.Users.GetUsersByEmailAsync(email);

            return users.Count > 0;
        }

        public async Task<TokenResponse> LoginAsync(string username, string password)
        {
            var response = new TokenResponse();

            try
            {
                var auth0Response = await _authenticationApiClient.GetTokenAsync(new ResourceOwnerTokenRequest
                {
                    ClientId = _authConfig.ClientId,
                    ClientSecret = _authConfig.ClientSecret,
                    Audience = _authConfig.Audience,
                    Scope = _authConfig.Scope,
                    Username = username,
                    Password = password
                });

                response = Mapper.Map<TokenResponse>(auth0Response);
            }
            catch (Exception ex)
            {
                response.IsSucceed = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<ResetPasswordResponse> ResetPasswordAsync(string email)
        {
            var response = new ResetPasswordResponse();

            try
            {
                var auth0Response = await _authenticationApiClient.ChangePasswordAsync(new ChangePasswordRequest
                {
                    Email = email,
                    ClientId = _authConfig.ClientId,
                    Connection = _authConfig.Connection
                });
            }
            catch (Exception ex)
            {
                response.IsSucceed = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}