using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;
using MoviesApp.Data.Services;

namespace MoviesApp.Pages
{
    //[Authorize(Roles = "Admin, Manager")]
    [Authorize(Policy = "GraduatedOnly")]
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        private IMoviesService _movieService;

        public AddMovieModel(IMoviesService movieService)
        {
            _movieService = movieService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _movieService.Add(Movie);

            return Redirect("Movies");
        }
    }
}