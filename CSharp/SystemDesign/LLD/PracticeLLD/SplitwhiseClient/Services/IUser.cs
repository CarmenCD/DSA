using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitWiseClient.Models;

namespace SplitWiseClient.Services
{
    public class IUser
    {
        User RegisterUser(string userName, string phone, string password);
        User GetUser(long newUserId);
    }
}
