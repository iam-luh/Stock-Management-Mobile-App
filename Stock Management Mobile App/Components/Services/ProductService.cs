using Stock_Management_Mobile_App.Components.Models;
using System.Text.Json;

namespace Stock_Management_Mobile_App.Components.Services
{
    public class ProductService
    {
        string filepath = string.Empty;

        public ProductService()
        {
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "products.json");
        }

        public void SaveProducts(List<Product> items)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(items));
        }

        public List<Product> GetProducts()
        {
            if (!File.Exists(filepath))
                return new List<Product>();

            return JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(filepath)) ??
                   new List<Product>();
        }
    }
}
