using Microsoft.Extensions.Logging;
using Stock_Management_Mobile_App.Components.Services;

namespace Stock_Management_Mobile_App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<TransactionService>();
            builder.Services.AddSingleton<CustomerService>();
            builder.Services.AddSingleton<ProductService>();
            builder.Services.AddSingleton<ProductStockAdditionService>();
            builder.Services.AddSingleton<Product_Category_ColorService>();
            builder.Services.AddSingleton<ExpenseService>();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
