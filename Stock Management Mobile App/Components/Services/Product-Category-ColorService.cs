using Stock_Management_Mobile_App.Components.Models;
using System.Text.Json;

namespace Stock_Management_Mobile_App.Components.Services
{
    public class Product_Category_ColorService
    {
        string filepath = string.Empty;

        public Product_Category_ColorService()
        {
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "productcategorycolor.json");
        }

        public void SaveTransactions(List<Product_Category_Color> items)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(items));
        }

        public List<Product_Category_Color> GetTransactions()
        {
            if (!File.Exists(filepath))
                return new List<Product_Category_Color>();

            return JsonSerializer.Deserialize<List<Product_Category_Color>>(File.ReadAllText(filepath)) ??
                   new List<Product_Category_Color>();
        }
    }
}
