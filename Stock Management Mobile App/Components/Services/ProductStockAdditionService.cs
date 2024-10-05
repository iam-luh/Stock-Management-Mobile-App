using Stock_Management_Mobile_App.Components.Models;
using System.Text.Json;

namespace Stock_Management_Mobile_App.Components.Services
{
    public class ProductStockAdditionService
    {
        string filepath = string.Empty;

        public ProductStockAdditionService()
        {
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "productstockadditions.json");
        }

        public void SaveTransactions(List<ProductStockAddition> items)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(items));
        }

        public List<ProductStockAddition> GetTransactions()
        {
            if (!File.Exists(filepath))
                return new List<ProductStockAddition>();

            return JsonSerializer.Deserialize<List<ProductStockAddition>>(File.ReadAllText(filepath)) ??
                   new List<ProductStockAddition>();
        }
    }
}
