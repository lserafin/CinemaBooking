using CinemaBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBooking.Controllers
{
    public class MovieController : Controller
    {
        [Route("movie/index")]
        public IActionResult Index()
        {
            return Ok("Hello World from the movie index action :)");
        }

        [Route("movie/{id}")]
        public IActionResult Movie(int id)
        {
            var movie = new Movie {  Title = "Inception", MovieId = 0 };
            return Ok(movie);
        }
    }
}