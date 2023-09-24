using SplitWiseClient.RegisterUserDTO;
using SplitWiseClient.Services;

namespace SplitWiseClient.Controllers
{
    // take the input, pass to service and return the output
    public class UserController
    {
        private readonly UserService _userService;

        // pass as a parameter because controller does not need handle all dependencies of service
        // only b=need the service not all things that service needs
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestDto">data transfer objects request</param>
        /// <returns>data transfer objects response</returns>
        public RegisterUserResponse RegisterUser(RegisterUserRequest requestDto)
        {
            var response = new RegisterUserResponse();
            try
            {
                var newUser = _userService.RegisterUser(requestDto.UserName, requestDto.PhoneNumber, requestDto.Password);

                var user = _userService.GetUser(newUser.Id);

                response.UserId = newUser.Id;
                response.Status = "Success";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                response.Status = "Error";
                response.Message = e.Message;
            }
            
        }
    }
}
