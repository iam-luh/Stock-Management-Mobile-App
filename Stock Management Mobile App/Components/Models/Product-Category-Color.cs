using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Product_Category_Color
    {
        public int ProductId { get; set; }
        public string? Category {  get; set; }
        public string? Color { get; set; }
        public int ProductQuantity { get; set; }
    }
}
