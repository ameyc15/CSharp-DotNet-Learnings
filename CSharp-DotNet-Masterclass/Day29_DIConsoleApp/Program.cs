using Microsoft.Extensions.DependencyInjection;

namespace Day29_DIConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IProductService, FurnitureProductService>();
            services.AddScoped<IProductService, ElectronicsProductService>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            
            using(var scope = serviceProvider.CreateScope())
            {
                var productServices = scope.ServiceProvider.GetServices<IProductService>();           

                

                foreach(var service in productServices)
                {
                    Console.WriteLine(service.GetType().Name);
                    Console.WriteLine(service.GetAllProducts().Count());
                    Console.WriteLine("Hashcode : " + services.GetHashCode());
                }

                
                
            }

            

            
        }
    }
}
