using Splitwise.Client.Commands;
using SplitWiseClient.Controllers;
using SplitWiseClient.Services;

namespace SplitWiseClient.Commands
{
    public class CommandRegistry
    {
        public List<ICommand> Commands;

        public CommandRegistry()
        {
            Commands = new List<ICommand>
            {
                new RegisterUserCommand(new UserController(new UserService()))
            };
        }
        
    }
}
