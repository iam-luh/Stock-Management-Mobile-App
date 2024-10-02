using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; } 
        public int PurchasePrice { get; set; }
        public int RetailPrice { get; set; }
        public int WholeSalePrice { get; set; }
    }
}
