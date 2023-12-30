using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public User User;
        public string Alias;
        public Symbol UserSymbol;

        public Player(User user, string alias, Symbol symbol)
        {
            this.User = user;
            this.Alias = alias;
            this.UserSymbol = symbol;
            
        }
    }
}
