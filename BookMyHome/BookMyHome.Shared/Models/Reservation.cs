using System;
using System.ComponentModel.DataAnnotations;

namespace BookMyHome.Shared.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public DateTime ReservationStartDate { get; set; }

        [Required]
        public DateTime ReservationEndDate { get; set; }

        [Required]
        public double ReservationPrice { get; private set; }

        public int GuestId { get; set; }
        public int ListingId { get; set; }

        public void NewReservation(int reservationId, int guestId, int listingId, DateTime startDate, DateTime endTime, double reservationPrice)
        {
            if (startDate >= endTime)
                throw new ArgumentException("startDate must be earlier than endTime.", nameof(startDate));

            ReservationId = reservationId;
            GuestId = guestId;
            ListingId = listingId;
            ReservationStartDate = startDate;
            ReservationEndDate = endTime;
            ReservationPrice = reservationPrice;
        }
    }
}
