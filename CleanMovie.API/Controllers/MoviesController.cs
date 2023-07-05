using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _movieService.GetAllMovies();
            return Ok(moviesFromService);
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie movie)
        {
            var movieFromService = _movieService.CreateMovie(movie);
            return Ok(movieFromService);
        }
    }
}
