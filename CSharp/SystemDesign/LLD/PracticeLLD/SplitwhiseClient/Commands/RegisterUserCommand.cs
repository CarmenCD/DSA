using Splitwise.Client.Commands;
using SplitWiseClient.Controllers;
using SplitWiseClient.RegisterUserDTO;

namespace SplitWiseClient.Commands
{
    public class RegisterUserCommand : ICommand
    {
        readonly UserController _controller;

        public RegisterUserCommand(UserController controller)
        {
            _controller = controller;
        }
        public void Execute(string input)
        {
            var result = input.Split(' ').ToList();
            var userName = result[1];
            var password = result[3];
            var phoneNumber = result[2];

            // call the controller to get the user registered
            var requestDto = new RegisterUserRequest
            {
                UserName = userName,
                Password = password,
                PhoneNumber = phoneNumber
            };
            _controller.RegisterUser(requestDto);

        }

        // register username, phone, password
        public bool Match(string input)
        {
            var result = input.Split(' ').ToList();

            if (result.Count != 4)
            {
                return false;
            }

            if(!result[0].Equals("register", StringComparison.OrdinalIgnoreCase)) { }

            return true;
        }
    }
}
