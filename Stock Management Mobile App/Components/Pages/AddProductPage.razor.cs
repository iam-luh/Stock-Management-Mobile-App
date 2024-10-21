

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Stock_Management_Mobile_App.Components.Models;
using Stock_Management_Mobile_App.Components.Services;

namespace Stock_Management_Mobile_App.Components.Pages
{
    public partial class AddProductPage
    {
        private Product Myproduct {  get; set; }
        private Product_Category_Color Product_Category {  get; set; }
        private List<Product> allproducts;
        private List<Product_Category_Color> allproductcategories;
        private List<string> addedproductcategories;
        private List<string> addedproductsubcategories;
        private List<string> allproductunits;
        public AddProductPage() 
        {
           Myproduct = new ();
           Product_Category = new (); 
           allproducts = [];
           allproductcategories = [];
           addedproductcategories = [];
           addedproductsubcategories = [];
           allproductunits = [];
            allproductunits.AddRange(["Pcs","Units","Kgs","Grams","Bells","Boxes","People","Dozens","Mtrs","Ltrs","Cms","Kms"]);

        }
        protected async override Task OnInitializedAsync()
        {
            allproducts = productservice.GetProducts();
            allproductcategories = productcategoryservice.GetProductCategories();
        }

        private void AddProductCategory(ChangeEventArgs keyvalue)
        {
            if(string.IsNullOrWhiteSpace(keyvalue.Value.ToString()) || !IsLastCharacterComma(keyvalue.Value.ToString()))
            {
                return;
            }
            addedproductcategories.Add(RemoveLastCharacter(keyvalue.Value.ToString()));
            Product_Category.Category = string.Empty;
            keyvalue.Value = string.Empty;

        }

        private void AddProductSubCategory(ChangeEventArgs keyvalue)
        {
            
            if ( string.IsNullOrWhiteSpace(keyvalue.Value.ToString()) || !IsLastCharacterComma(keyvalue.Value.ToString()))
            {
                return;
            }
            Product_Category.SubCategory = string.Empty;
            addedproductsubcategories.Add(RemoveLastCharacter(keyvalue.Value.ToString()));
            Product_Category.SubCategory = string.Empty;
            keyvalue.Value = string.Empty;

        }

        private void RemoveProductCategory(string category)
        {
            addedproductcategories.Remove(category);
        }

        private void RemoveProductSubCategory(string subcategory)
        {
            addedproductsubcategories.Remove(subcategory);
        }
        private bool IsLastCharacterComma(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            char lastCharacter = input[^1];
            return lastCharacter == ',';
        }

        private void SaveProduct()
        {
            Myproduct.CreatedDate = DateTime.Now;
            Myproduct.UpdatedDate = DateTime.Now;
            Myproduct.Id = allproducts.Count + 1;
            allproducts.Add(Myproduct);
            foreach (var item in addedproductcategories)
            {
                foreach (var item2 in addedproductsubcategories)
                {
                    allproductcategories.Add(new() 
                    {  ProductId= Myproduct.Id,
                       AvailableProductQuantity= Product_Category.AvailableProductQuantity,
                       Category = item, 
                       SubCategory = item2,
                       PurchasePrice= Product_Category.PurchasePrice,
                       RetailPrice = Product_Category.RetailPrice,
                       WholeSalePrice= Product_Category.WholeSalePrice
                      
                    });
                }
            }
            productservice.SaveProducts(allproducts);
            productcategoryservice.SaveProductCategories(allproductcategories);
            App.Current.MainPage.DisplayAlert("Success", "Product Added Successfully", "Ok");
            Myproduct.ProductName = string.Empty;
            Myproduct.ProductDescription = string.Empty;
            Product_Category.AvailableProductQuantity = 0;
            Product_Category.PurchasePrice = 0;
            Product_Category.RetailPrice = 0;
            Product_Category.WholeSalePrice = 0;
        }
        public string RemoveLastCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, input.Length - 1);
        }

        

        
    }
}