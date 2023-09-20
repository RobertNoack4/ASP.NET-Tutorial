using MoviesApp.Data.Models;

namespace MoviesApp.Data.Services
{
    public class MovieService : IMoviesService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {

            _context = context;

        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public Movie? Get(int id)
        {
            return _context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }
    }
}
