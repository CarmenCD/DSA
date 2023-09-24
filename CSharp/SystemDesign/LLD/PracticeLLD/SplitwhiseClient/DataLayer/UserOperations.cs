using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitWiseClient.Models;

namespace SplitWiseClient.DataLayer
{
    internal class UserOperations : IUserOperation
    {
        public async Task<User> FindUserById(long id)
        {
            var user  = new User();
            await using var context = new ApplicationDbContext();
            user = await context.Users.FindAsync(id);
            if (user == null)
                throw new Exception("User was not found");

            return user;
        }

        public async Task<User> FindUserByName(string userName)
        {
            var user = new User();
            await using var context = new ApplicationDbContext();
            user = await context.Users.FindAsync(userName);
            if (user == null)
                throw new Exception("User was not found");

            return user;
        }

        public async Task<User> FindUserByPhone(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async void CreateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
