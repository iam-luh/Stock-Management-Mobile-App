

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? ProductCategory { get; set; }
        public int ProductID { get; set; }
        public string? ProductColor { get; set; }
        public int ExpenseID { get; set; }
        public int CustomerID { get; set; }
        public string? TransactionDescription { get; set; }
        public int TransactionPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsExpense { get; set; }
        public bool IsPaid { get; set; }

    }
}
