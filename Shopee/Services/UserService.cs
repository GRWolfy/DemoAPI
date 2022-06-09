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

        public async Task<RequestResponse> checkUser(UserLoginRequest userLoginRequest)
        {
            //4220
            var checkIfUserExist = _shopeeContext.Users.Where(x => x.Username == userLoginRequest.username
                && x.Password == userLoginRequest.password).FirstOrDefault();

            if (checkIfUserExist != null)
            {
                var response = new RequestResponse
                {
                    responseMessage = checkIfUserExist.Username + " is found! ",
                    responseCode = 1
                };

                return response;
            }
            else
            {
                var response = new RequestResponse
                {
                    responseMessage = userLoginRequest.username + " is not found! ",
                    responseCode = 9
                };

                return response;
            }
            //dependency injection
        }

        public async Task<RequestResponse> addUser(AddUserRequest addUserRequest)
        {
            var newUser = new User
            {
                Username = addUserRequest.username,
                Password = addUserRequest.password,
                Firstname = addUserRequest.firstname,
                Lastname = addUserRequest.lastname
            };

            _shopeeContext.Users.Add(newUser);
            _shopeeContext.SaveChanges();

            var response = new RequestResponse
            {
                responseMessage = addUserRequest.username + " is added! ",
                responseCode = 1
            };

            return response;
        }
    }
}
