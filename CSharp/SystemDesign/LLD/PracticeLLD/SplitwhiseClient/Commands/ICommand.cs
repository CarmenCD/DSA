using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwise.Client.Commands
{
    public interface ICommand
    {
        void Execute(string input);
        bool Match(string input);
        //list<string> ValidateInput(); - can return list of errors
    }
}
