using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Models
{

    public class Address
    {
        public string? StateAbbreviation { get; set; }
        public string? StreetNumber { get; set; }
        public string? UnitNumber { get; set; }
        public string? Street { get; set; }
        public string? Suburb { get; set; }
        public string? Postcode { get; set; }
        public string? DisplayAddress { get; set; }
    
        public Address() { 
        }

    }
}
