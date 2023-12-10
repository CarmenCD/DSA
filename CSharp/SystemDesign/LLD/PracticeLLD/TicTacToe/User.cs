using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class User
    {
        public string UserId;
        public string Name;
        //public PersonalDetails PersonalDetails { get; set; }
        //public Statistic Statistic { get; set; }
    }

    public class Statistic
    {
        public int Score { get; set; }
        public int Rank { get; set; }
    }

    public class PersonalDetails
    {
        public string Name { get; set; }
       
    }
}
