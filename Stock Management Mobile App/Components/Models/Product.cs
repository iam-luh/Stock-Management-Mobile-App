

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }         
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? ProductUnit { get; set; }
    }
}
