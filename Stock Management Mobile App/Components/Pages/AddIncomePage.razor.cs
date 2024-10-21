using Microsoft.AspNetCore.Components;
using Stock_Management_Mobile_App.Components.Models;


namespace Stock_Management_Mobile_App.Components.Pages
{
    public partial class AddIncomePage
    {

        private Transaction MyTransaction{ get; set; }
        private Product MyProduct { get; set; }
        private Product_Category_Color Product_Category { get; set; }
        private List<Transaction> alltransactions;
        private List<Product> allproducts;
        private List<Product_Category_Color> allproductcategories;
        private List<string> sortedproductcategories;
        private List<string> sortedproductsubcategories;
        private void SaveIncome()
        {
            
        }
        public AddIncomePage()
        {
            MyTransaction = new();
            MyProduct = new();
            Product_Category = new();
            alltransactions = [];
            allproducts = [];
            allproductcategories = [];
            sortedproductcategories = [];
            sortedproductsubcategories = []; 
        }
        protected async override Task OnInitializedAsync()
        {

            alltransactions = transactionservice.GetTransactions();
            allproducts = productservice.GetProducts();
            allproductcategories = productcategoryservice.GetProductCategories();
        }
        private void SortProductCategories(ChangeEventArgs e)
        {
            var productname = e.Value?.ToString() ?? string.Empty;
            var productID = allproducts.Where(x => x.ProductName == productname).Select(x => x.Id).FirstOrDefault();
            sortedproductcategories = allproductcategories
                .Where(x => x.ProductId == productID)
                .Select(x => x.Category ?? string.Empty)
                .Distinct()
                .ToList();
        }
        private void SortProductSubCategories(ChangeEventArgs e)
        {
            var productcategory = e.Value?.ToString() ?? string.Empty;
            sortedproductsubcategories = allproductcategories
                .Where(x => (x.Category ?? string.Empty).Equals(productcategory))
                .Select(x => x.SubCategory ?? string.Empty)
                .Distinct()
                .ToList();
        }
        private int GetRetailPrice(int productId, string category, string subCategory)
        {
            var product = allproductcategories.FirstOrDefault(x => x.ProductId == productId && x.Category == category && x.SubCategory == subCategory);
            return product?.RetailPrice ?? 0;
        }
        private int GetWholesalePrice(int productId, string category, string subCategory)
        {
            var product = allproductcategories.FirstOrDefault(x => x.ProductId == productId && x.Category == category && x.SubCategory == subCategory);
            return product?.WholeSalePrice ?? 0;
        }
        private void SaveTransaction()
        {
            MyTransaction.Id = alltransactions.Count + 1;
            MyTransaction.ProductName = MyProduct.ProductName;
            MyTransaction.ProductCategory = Product_Category.Category;
            MyTransaction.ProductSubCategory = Product_Category.SubCategory;
            MyTransaction.CreatedDate = DateTime.Now;
            MyTransaction.UpdatedDate = DateTime.Now;
            MyTransaction.IsExpense = false;
            MyTransaction.IsPaid = true;
            alltransactions.Add(MyTransaction);
            transactionservice.SaveTransactions(alltransactions);
        }


    }
}