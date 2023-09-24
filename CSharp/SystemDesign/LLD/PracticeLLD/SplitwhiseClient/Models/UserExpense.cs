namespace SplitWiseClient.Models
{
    public class UserExpense : BaseModel
    {
        public User User { get; set; }
        public Expense Expense { get; set; }
        public int Amount { get; set; }

        public UserExpenseType UserExpenseType { get; set; }
    }
}
