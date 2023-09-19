using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; } 

        public void OnGet()
        {
            Movie = new Movie
            {
                Title = string.Empty,
                Description = string.Empty,
                Rate = 0
            };
        }

        public IActionResult OnPost()
        {
            string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";

            if(!ModelState.IsValid)
            {
                return Page();
            }

            return Redirect("Movies");
        }
    }
}
