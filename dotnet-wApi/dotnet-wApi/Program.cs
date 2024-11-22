using dotnet_core;

namespace dotnet_wApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            WebApplication webApplication = builder.Build();

            webApplication.MapGet("/product", (HttpContext httpContext) =>
            {
                Product product = new()
                {
                    Id = 3,
                    Title = "Product 3",
                    Price = 30
                };

                return product;
            });

            webApplication.Run();
        }
    }
}
