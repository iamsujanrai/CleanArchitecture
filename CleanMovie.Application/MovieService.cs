using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            var createdMovie = _movieRepository.CreateMovie(movie);
            return createdMovie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
