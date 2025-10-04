using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Models
{
    public class PriceDetails
    {
        public int price { get; set; }
        public int? priceFrom { get; set; }
        public int? priceTo { get; set; }

    public PriceDetails() { 
        }
    }
}
