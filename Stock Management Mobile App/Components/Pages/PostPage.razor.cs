namespace Stock_Management_Mobile_App.Components.Pages
{
    public partial class PostPage
    {
        private void GoToAddProduct()
        {
            navigation.NavigateTo("/addproduct");
        }
        private void GoToAddIncome()
        {
            navigation.NavigateTo("/addincome");
        }
        private void GoToAddCustomer()
        {
            navigation.NavigateTo("/addcustomer");
        }
        private void GoToAddExpense()
        {
            navigation.NavigateTo("/addexpense");
        }
        private void GoToProductRestock()
        {
            navigation.NavigateTo("/productrestock");
        }


    }
}