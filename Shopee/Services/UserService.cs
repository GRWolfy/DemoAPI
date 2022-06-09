using Shopee.Models;
using Shopee.DataAccess.Models;

namespace Shopee.Services
{
    public class UserService : IUserService
    {
        private ShopeeContext _shopeeContext;

        public UserService(ShopeeContext shopeeContext)
        {
            _shopeeContext = shopeeContext;
        }

        public async Task<UserLoginResponse> checkUser(UserLoginRequest userLoginRequest)
        {
            //4220
            var checkIfUserExist = _shopeeContext.Users.Where(x => x.Username == userLoginRequest.username
                && x.Password == userLoginRequest.password).FirstOrDefault();

            if (checkIfUserExist != null)
            {
                var response = new UserLoginResponse
                {
                    responseMessage = checkIfUserExist.Username + " is found! ",
                    responseCode = 1
                };

                return response;
            }
            else
            {
                var response = new UserLoginResponse
                {
                    responseMessage = userLoginRequest.username + " is not found! ",
                    responseCode = 9
                };

                return response;
            }

            //dependency injection
        }
    }
}
