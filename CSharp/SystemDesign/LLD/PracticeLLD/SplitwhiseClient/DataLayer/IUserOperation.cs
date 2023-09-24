using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitWiseClient.Models;

namespace SplitWiseClient.DataLayer
{
    public interface IUserOperation
    {
        Task<User> FindUserById(long id);
        Task<User> FindUserByName(string userName);
        Task<User> FindUserByPhone(string phoneNumber);

        void CreateUser(User user);
    }
}
