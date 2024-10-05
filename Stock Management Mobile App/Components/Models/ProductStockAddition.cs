

namespace Stock_Management_Mobile_App.Components.Models
{
    public class ProductStockAddition
    {
        public int ProductID { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductColor { get; set; }
        public int Quantity { get; set; }
        public string? Units { get; set; }
        public int PurchasePrice { get; set; }
    }
}
