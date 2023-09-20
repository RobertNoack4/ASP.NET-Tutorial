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
