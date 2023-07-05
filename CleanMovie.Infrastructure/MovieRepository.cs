using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public static List<Movie> movies = new List<Movie>
        {
            new Movie {Id= 1, Name ="Passion of Christ", Price =200 },
            new Movie {Id= 2, Name ="Home Alone", Price =300 }
        };

        public Movie CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
