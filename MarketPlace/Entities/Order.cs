using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime registrationDate { get; set; }

        public List<ProductCart> ClientProducts = new List<ProductCart>();
        public bool IsPaid { get; set; }
    }
}
