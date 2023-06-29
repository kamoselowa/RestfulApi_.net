using Microsoft.EntityFrameworkCore;
using HotelbookingAPI.models;


namespace Hotelbooking.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }   
       public ApiContext(DbContextOptions<ApiContext> options) :base(options) 
        {
        }
    }
}
