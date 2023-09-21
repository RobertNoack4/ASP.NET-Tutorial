using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;
using MoviesApp.Data.Services;

namespace MoviesApp.Pages
{
    public class MovieModel : PageModel
    {
        public Movie? Movie { get; set; }
        private IMoviesService _movieService;

        public MovieModel(IMoviesService movieService)
        {
            _movieService = movieService;
        }

        public void OnGet(int id)
        {
            Movie = _movieService.Get(id);
        }
    }
}