using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public required Address Address { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int BuildingAreaSqm { get; set; }
        public int CarSpaces { get; set; }
        public DateTime DateListed { get; set; }
        public required string Description { get; set; }
        public int LandAreaSqm { get; set; }
        public Media[]? Media { get; set; }
        public required PriceDetails PriceDetails { get; set; }
        public int? PropertyId { get; set; }

        public Listing() { 
        }





    }




}
