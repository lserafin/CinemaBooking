using System;

namespace CinemaBooking.Models
{
    public class Screening
    {
        public int ScreeningId { get; set; }

        public DateTime Time {get; set; }

        public Room Room { get; set; }

        public Movie Movie { get; set; }

    }
}