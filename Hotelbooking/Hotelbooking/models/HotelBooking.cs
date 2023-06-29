using Microsoft.EntityFrameworkCore;



namespace HotelbookingAPI.models
{
    public class HotelBooking
    {
        public int Id {get; set;}   
        public int RoomNumber { get; set;}
        public string ClientName { get; set;}
    }
}
