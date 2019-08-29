using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductViewModels
{
    public class MyProductsViewModel
    {
        public Product Product { get; set; }

        public int NumberSold { get; set; }

        public double Rating { get; set; }

    }
}
