using Stock_Management_Mobile_App.Components.Models;
using System.Text.Json;

namespace Stock_Management_Mobile_App.Components.Services
{
    public class ExpenseService
    {
        string filepath = string.Empty;

        public ExpenseService()
        {
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "expenses.json");
        }

        public void SaveTransactions(List<Expense> items)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(items));
        }

        public List<Expense> GetTransactions()
        {
            if (!File.Exists(filepath))
                return new List<Expense>();

            return JsonSerializer.Deserialize<List<Expense>>(File.ReadAllText(filepath)) ??
                   new List<Expense>();
        }
    }
}
