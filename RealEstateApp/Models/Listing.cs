using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Models
{
    class Listing
    {

        public class Rootobject
        {
            public string objective { get; set; }
            public string status { get; set; }
            public string saleMode { get; set; }
            public string channel { get; set; }
            public int id { get; set; }
            public Addressparts addressParts { get; set; }
            public Advertiseridentifiers advertiserIdentifiers { get; set; }
            public Apmidentifiers apmIdentifiers { get; set; }
            public int bathrooms { get; set; }
            public int bedrooms { get; set; }
            public string buildingArea { get; set; }
            public int buildingAreaSqm { get; set; }
            public int carspaces { get; set; }
            public DateTime dateAvailable { get; set; }
            public DateTime dateCreated { get; set; }
            public DateTime dateUpdated { get; set; }
            public DateTime dateMinorUpdated { get; set; }
            public DateTime datePurged { get; set; }
            public DateTime dateListed { get; set; }
            public string description { get; set; }
            public int devProjectId { get; set; }
            public int energyEfficiencyRating { get; set; }
            public string[] features { get; set; }
            public Geolocation geoLocation { get; set; }
            public string headline { get; set; }
            public Inspectiondetails inspectionDetails { get; set; }
            public bool isNewDevelopment { get; set; }
            public string landArea { get; set; }
            public int landAreaSqm { get; set; }
            public Medium[] media { get; set; }
            public Pricedetails priceDetails { get; set; }
            public string propertyId { get; set; }
            public string[] propertyTypes { get; set; }
            public Providerdetails providerDetails { get; set; }
            public Rentaldetails rentalDetails { get; set; }
            public Saledetails saleDetails { get; set; }
            public bool isWithdrawn { get; set; }
            public string seoUrl { get; set; }
            public string virtualTourUrl { get; set; }
            public bool homepassEnabled { get; set; }
            public Statementofinformation statementOfInformation { get; set; }
            public int numberOfDwellings { get; set; }
            public string[] highlights { get; set; }
        }

        public class Addressparts
        {
            public string stateAbbreviation { get; set; }
            public string displayType { get; set; }
            public string streetNumber { get; set; }
            public string unitNumber { get; set; }
            public string street { get; set; }
            public string suburb { get; set; }
            public int suburbId { get; set; }
            public string postcode { get; set; }
            public string displayAddress { get; set; }
        }







        public class Pricedetails
        {
            public string gstOption { get; set; }
            public string priceType { get; set; }
            public string priceUnit { get; set; }
            public int price { get; set; }
            public int priceFrom { get; set; }
            public int priceTo { get; set; }
            public string pricePrefix { get; set; }
            public bool canDisplayPrice { get; set; }
            public string[] hiddenReasons { get; set; }
            public string displayPrice { get; set; }
            public int bond { get; set; }
            public bool priceReduction { get; set; }
        }





    }
}
