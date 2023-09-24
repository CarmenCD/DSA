using SplitWiseClient.DataLayer;
using SplitWiseClient.Models;

namespace SplitWiseClient.Services
{
    public class UserService
    {
        private IUserOperation _operations;

        public UserService(IUserOperation operations)
        {
            _operations = operations;
        }
        public User RegisterUser(string userName, string phone, string password)
        {
            // check if the user already in db - we will use entity framework
            var result = _operations.FindUserByName(userName);
            // if true return some exception
            // else register
            // return user
            throw new NotImplementedException();

        }

        public User GetUser(long newUserId)
        {
            throw new NotImplementedException();
        }
    }
}
