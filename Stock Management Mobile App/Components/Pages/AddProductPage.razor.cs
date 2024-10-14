
using Android.App;
using Java.Util;
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

        public AddProductPage() 
        {
           Myproduct = new ();
           Product_Category = new ();
           allproducts = [];
            allproductcategories = [];
        }
        protected async override Task OnInitializedAsync()
        {
            allproducts = productservice.GetProducts();
            allproductcategories = productcategoryservice.GetProductCategories();

        }
    }
}