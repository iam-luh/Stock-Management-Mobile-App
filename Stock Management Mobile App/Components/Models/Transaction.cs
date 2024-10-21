

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductName { get; set; }
        public string? ProductSubCategory { get; set; }
        public int ProductQuantity { get; set; }
        public string? ExpenseName { get; set; }
        public int CustomerID { get; set; }
        public string? TransactionDescription { get; set; }
        public int TransactionPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsExpense { get; set; }
        public bool IsPaid { get; set; }

    }
}
