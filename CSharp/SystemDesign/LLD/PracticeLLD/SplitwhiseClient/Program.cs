// See https://aka.ms/new-console-template for more information

using Splitwise.Client.Commands;
using SplitWiseClient.Commands;

Console.WriteLine("Hello, World!");
// register commands
var registry = new CommandRegistry();

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