namespace Day28_DependencyInjection.Services
{
    public class ElectronicsProduct :IProductService
    {
        public List<String> GetAllProducts()
        {
            List<string> electronicsProducts = new List<string>()
            {
                "Iphone",
                "Lenevo Laptop",
                "Macbook",
                "One Plus"

            };
            return electronicsProducts;
        }
    }
}
