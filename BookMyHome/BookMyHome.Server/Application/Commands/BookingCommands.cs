using BookMyHome.Server.Infrastructure;
using BookMyHome.Shared.Models;
using Microsoft.AspNetCore.SignalR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookMyHome.Server.Application.Commands
{
    public class BookingCommands
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbContext _dbContext;

        public BookingCommands(IUnitOfWork unitOfWork, DbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _dbContext = dbContext;
        }

        // Add methods to handle booking commands here
        public async Task CreateBookingAsync(BookingCommands command)
        {
            var booking = new Booking
            {
                BookingId = Id.NewId(),
                GuestId = command.GuestId,
                ListingId = command.ListingId,
                BookingStartDate = command.StartDate,
                BookingEndDate = command.EndDate,
                BookingPrice = command.Price,
                
            };
            return Task.CompletedTask;
        }
    }
}
