using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29_DIConsoleApp
{
    internal class FurnitureProductService :IProductService
    {
        public List<String> GetAllProducts()
        {
            return new List<String>
            {
                "table",
                "chair"
            };
        }
    }
}
