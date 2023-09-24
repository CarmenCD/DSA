namespace SplitWiseClient.Models
{
    public class Expense: BaseModel
    {
        public double TotalAmount { get; set; }
        public string Description { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public User CreatedBy { get; set; }
        public Group Group { get; set; }
    }
}