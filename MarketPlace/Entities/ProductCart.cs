using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities
{
    internal class ProductCart
    {
       public Product Product { get; set; }
        public int Count { get; set; }
        public Decimal TotalPrice { get; set; }

        public Decimal  GetTotalPrice()
        {
           return this.Product.Price * this.Count;
        }
    }
}
