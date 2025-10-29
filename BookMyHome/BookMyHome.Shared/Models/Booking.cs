using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyHome.Shared.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public DateTime BookingStartDate { get; set; }

        [Required]
        public DateTime BookingEndDate { get; set; }

        [Required]
        public double BookingPrice { get; private set; }

        public int GuestId { get; set; }
        public int ListingId { get; set; }

        [Timestamp]  // Optimistic concurrency
        public byte[] RowVersion { get; set; }

        public void NewBooking(int bookingId, int guestId, int listingId, DateTime startDate, DateTime endTime, double bookingPrice)
        {
            if (startDate >= endTime)
                throw new ArgumentException("startDate must be earlier than endTime.", nameof(startDate));

            BookingId = bookingId;
            GuestId = guestId;
            ListingId = listingId;
            BookingStartDate = startDate;
            BookingEndDate = endTime;
            BookingPrice = bookingPrice;
        }
    }
}
