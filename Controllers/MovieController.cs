using System.Collections.Generic;
using System.Collections.ObjectModel;
using CinemaBooking.Data;
using CinemaBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBooking.Controllers
{
    public class MovieController : Controller
    {
        [Route("movie/index")]
        [HttpGet]
        public IActionResult Index()
        {
            ICollection<Movie> movies = new Collection<Movie>();
            using (var db = new CinemaContext())
            {
                foreach (var movie in db.Movies)
                {
                    movies.Add(new Movie {  Title = movie.Title, MovieId = movie.MovieId });                    
                }
            }
            
            return Ok(movies);
        }

        [Route("movie/insert")]
        [HttpPost]
        public IActionResult Insert([FromBody] Movie movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            string result = "";
            using (var db = new CinemaContext())
            {
                db.Movies.Add(movie);
                var count = db.SaveChanges();
                result = count + " records saved to database";
            }
            return Ok(result);
        }
    }
}