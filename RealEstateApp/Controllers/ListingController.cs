using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateApp.Models;

namespace RealEstateApp.Controllers
{
    public class ListingController
    {
        Listing demoListing = new()
        {
            Id = 0,
            Address = new Address { StateAbbreviation = "WA", StreetNumber = "1", Street = "Test Street", Suburb = "Perth", Postcode = "6000", DisplayAddress = " 1 Test Street, Perth 6000, WA" },
            Bathrooms = 1,
            Bedrooms = 2,
            BuildingAreaSqm = 300,
            CarSpaces = 3,
            DateListed = new DateTime(2025, 01, 01),
            Description = "This is a listing",
            LandAreaSqm = 400,
            PriceDetails = new PriceDetails { price = 100000 },
            PropertyId = 1
        };

        List<Listing> listingList = [
            new() { 
            Id = 0,
            Address = new Address { StateAbbreviation = "WA", StreetNumber = "1", Street = "Test Street", Suburb = "Perth", Postcode = "6000", DisplayAddress = " 1 Test Street, Perth 6000, WA" },
            Bathrooms = 1,
            Bedrooms = 2,
            BuildingAreaSqm = 300,
            CarSpaces = 3,
            DateListed = new DateTime(2025, 01, 01),
            Description = "This is a listing",
            LandAreaSqm = 400,
            PriceDetails = new PriceDetails { price = 100000 },
            PropertyId = 1},
            new() {
            Id = 1,
            Address = new Address { StateAbbreviation = "NSW", StreetNumber = "53", Street = "Seasame Street", Suburb = "Perth", Postcode = "6000", DisplayAddress = " 1 Seasame Street, Perth 6111, WA" },
            Bathrooms = 2,
            Bedrooms = 3,
            BuildingAreaSqm = 500,
            CarSpaces = 3,
            DateListed = new DateTime(2025, 01, 01),
            Description = "This is a listing",
            LandAreaSqm = 600,
            PriceDetails = new PriceDetails { price = 1000000 },
            PropertyId = 2},

            ];

        public Listing GetListing()
        {
            return demoListing;
        }


        public List<Listing> GetAllListings()
        {
            return listingList;
        }
    }
}
