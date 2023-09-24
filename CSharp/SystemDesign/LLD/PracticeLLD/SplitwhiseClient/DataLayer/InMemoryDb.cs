using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplitWiseClient.Models;

namespace SplitWiseClient.DataLayer
{
    public  class InMemoryDb : IUserOperation
    {
        private List<User> Users { get; set; }
        public Task<User> FindUserById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindUserByName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindUserByPhone(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
