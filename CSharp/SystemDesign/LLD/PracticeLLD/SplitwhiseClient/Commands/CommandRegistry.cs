using Splitwise.Client.Commands;
using SplitWiseClient.Controllers;
using SplitWiseClient.DataLayer;
using SplitWiseClient.Services;

namespace SplitWiseClient.Commands
{
    public class CommandRegistry
    {
        public List<ICommand> Commands;

        private readonly IUserOperation _operation;

        public CommandRegistry(IUserOperation operation)
        {
            _operation = operation;
            Commands = new List<ICommand>
            {
                new RegisterUserCommand(new UserController(new UserService(_operation)))
            };
        }
    }
}
