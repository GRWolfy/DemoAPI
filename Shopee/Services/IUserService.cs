using Shopee.Models;

namespace Shopee.Services
{
    public interface IUserService
    {
        Task<UserLoginResponse> checkUser(UserLoginRequest userLoginRequest);
    }
}
