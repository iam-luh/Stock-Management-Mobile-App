using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? TransactionCategory { get; set; }
        public string? TransactionDescription { get; set; }
        public int TransactionPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsExpense { get; set; }

    }
}
