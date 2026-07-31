using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Day28_DependencyInjection.Services
{
    public class FurnitureProduct : IProductService
    {
        public List<String> GetAllProducts()
        {
            List<String> furnitureProducts = new List<String>()
            {
                "Chair",
                "Table",
                "Sofa",
                "Work Desk"
            };

            return furnitureProducts;

        }
       
    }
}
