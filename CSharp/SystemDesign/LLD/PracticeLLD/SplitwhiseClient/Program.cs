// See https://aka.ms/new-console-template for more information

using SplitWiseClient.Commands;
using SplitWiseClient.DataLayer;

Console.WriteLine("Hello, World!");
// register commands
IUserOperation userOperationDb = new UserOperations();
var registry = new CommandRegistry(userOperationDb);

while (true)
{
    Console.WriteLine("> ");
    var userInput = Console.ReadLine();

    if (userInput.ToLower() == "exit")
    {
        Console.WriteLine("Exit the program ...");
        break;
    }

    bool matched = false;

    foreach (var command in registry.Commands)
    {
        if (command.Match(userInput))
        {
            matched = true;
            command.Execute(userInput);
            
        }
    }

    if (matched)
    {
        Console.WriteLine("Command executed success");
    }
    else
    {
        Console.WriteLine($"Incorrect user input {userInput}");
    }
    

}