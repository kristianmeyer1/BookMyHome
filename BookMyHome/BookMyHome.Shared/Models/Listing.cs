using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class Listing
    {
        [Key]
        public int ListingId { get; set; }
        [Required]
        public string ListingType { get; set; }
        [Required]
        public double ListingPrice { get; set; }
        [Required]
        public int ListingDuration { get; set; }
        [Required]
        public string ListingLocation { get; set; }
        [Required]
        public bool ListingAvailability { get; set; }

        public Listing(int listingId, string listingType, double listingPrice, int listingDuration, string listingLocation, bool listingAvailability)
        {
            ListingId = listingId;
            ListingType = listingType;
            ListingPrice = listingPrice;
            ListingDuration = listingDuration;
            ListingLocation = listingLocation;
            ListingAvailability = listingAvailability;
        }
    }
}
