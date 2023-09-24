using System.ComponentModel.DataAnnotations.Schema;

namespace SplitWiseClient.Models
{
    public class Group : BaseModel
    {
        //[ForeignKey("CreatedById")]
        public long CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Members { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
