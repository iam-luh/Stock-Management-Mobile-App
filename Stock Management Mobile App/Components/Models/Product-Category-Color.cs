

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Product_Category_Color
    {
        public int ProductId { get; set; }
        public string? Category {  get; set; }
        public string? SubCategory { get; set; }
        public int AvailableProductQuantity { get; set; }
        public int PurchasePrice { get; set; }
        public int RetailPrice { get; set; }
        public int WholeSalePrice { get; set; }
    }
}
