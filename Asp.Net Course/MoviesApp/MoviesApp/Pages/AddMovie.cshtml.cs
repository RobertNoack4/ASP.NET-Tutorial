using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;
using MoviesApp.Data.Services;

namespace MoviesApp.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        private MovieService _movieService;

        public AddMovieModel(MovieService movieService)
        {
            _movieService = movieService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";

            if(!ModelState.IsValid)
            {
                return Page();
            }

            _movieService.Add(Movie);

            return Redirect("Movies");
        }
    }
}
