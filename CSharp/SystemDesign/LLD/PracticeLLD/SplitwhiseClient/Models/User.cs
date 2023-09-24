using System.Security.AccessControl;

namespace SplitWiseClient.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public UserStatus UserStatus { get; set; }
        public List<Group> Groups { get; set; }
    }
}
