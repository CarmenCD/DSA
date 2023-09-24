using SplitWiseClient.Models;

namespace SplitWiseClient.Services
{
    public class UserService : IUser
    {
        public User RegisterUser(string userName, string phone, string password)
        {
            // check if the user already in db - we will use entity framework
            // if true return some exception
            // else register
            // return user
            throw new NotImplementedException();

        }

        public object GetUser(long newUserId)
        {
            throw new NotImplementedException();
        }
    }
}
