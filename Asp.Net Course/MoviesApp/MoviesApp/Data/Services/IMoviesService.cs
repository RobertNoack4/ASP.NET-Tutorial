using MoviesApp.Data.Models;

namespace MoviesApp.Data.Services
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        Movie? Get(int id);
        void Add(Movie movie);
    }
}
