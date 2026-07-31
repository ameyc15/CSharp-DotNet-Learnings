using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29_DIConsoleApp
{
    internal class ElectronicsProductService : IProductService
    {
        public List<string> GetAllProducts()
        {
            return new List<String>
            {
                "iphone",
                "oppo",
                "one plus"
            };
        }
    }
}
