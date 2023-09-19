using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = new List<Movie>()
            { new Movie()
                {
                    Title = "First movie title",
                    Rate = 10,
                    Description = "First movie description goes here...",
                    Id = 1,
                },
                new Movie()
                {
                    Title = "Second movie title",
                    Rate = 7,
                    Description = "Second movie description goes here...",
                    Id = 2,
                },
                new Movie()
                {
                    Title = "Third movie title",
                    Rate = 5,
                    Description = "Third movie description goes here...",
                    Id = 3,
                },
                new Movie()
                {
                    Title = "Fourth movie title",
                    Rate = 10,
                    Description = "Fourth movie description goes here...",
                    Id = 4,
                }
            };
        }
    }
}
