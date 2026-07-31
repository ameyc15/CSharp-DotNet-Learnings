using System.Security.Cryptography.X509Certificates;

namespace Day28_DependencyInjection.Services
{
    public class ProductService :IProductService
    {
        public List<string> GetAllProducts()
        {
            List<string> products = new List<string>();
            products.Add("Laptop");
            products.Add("Table");
            products.Add("Notebook");

            return products;
        }
    }
}
