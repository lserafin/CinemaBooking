using System.Collections.Generic;

namespace CinemaBooking.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public ICollection<Room> PlayingAt { get; set;}

    }
}