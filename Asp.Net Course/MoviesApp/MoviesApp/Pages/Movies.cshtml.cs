using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;
using MoviesApp.Data.Services;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        
        private IMoviesService _movieService;

        public MoviesModel(IMoviesService movieService)
        {
            _movieService = movieService;
        }

        public void OnGet()
        {
            Movies = _movieService.GetAll();
        }
    }
}
