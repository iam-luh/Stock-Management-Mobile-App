using Stock_Management_Mobile_App.Components.Models;
using System.Text.Json;

namespace Stock_Management_Mobile_App.Components.Services
{
    public class TransactionService
    {
        string filepath = string.Empty;

        public TransactionService()
        {
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "transactions.json");
        }

        public void SaveTransactions(List<Transaction> items)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(items));
        }

        public List<Transaction> GetTransactions()
        {
            if (!File.Exists(filepath))
                return new List<Transaction>();

            return JsonSerializer.Deserialize<List<Transaction>>(File.ReadAllText(filepath)) ??
                   new List<Transaction>();
        }
    }
}
