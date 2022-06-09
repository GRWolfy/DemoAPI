using Shopee.Models;

namespace Shopee.Services
{
    public interface IUserService
    {
        Task<UserLoginResponse> checkUser(Users userLoginRequest);
        Task<UserLoginResponse> addUser(Users addUserRequest);
    }
}
