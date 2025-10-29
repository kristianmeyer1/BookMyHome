using BookMyHome.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestBookMyHome
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void TestNewReservation()
        {
            int reservationId = 1;
            int guestId = 101;
            int listingId = 202;
            DateTime startDate = new DateTime(2024, 7, 1);
            DateTime endDate = new DateTime(2024, 7, 10);
            double reservationPrice = 1500.00;

            Reservation reservation = new Reservation();
            reservation.NewReservation(reservationId, guestId, listingId, startDate, endDate, reservationPrice);

            Assert.AreEqual(reservationId, reservation.ReservationId);
            Assert.AreEqual(startDate, reservation.ReservationStartDate);
            Assert.AreEqual(endDate, reservation.ReservationEndDate);
        }
    }
}
