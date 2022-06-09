using Shopee.Models;

namespace Shopee.Services
{
    public interface IUserService
    {
        Task<RequestResponse> checkUser(UserLoginRequest userLoginRequest);
        Task<RequestResponse> addUser(AddUserRequest addUserRequest);
    }
}
