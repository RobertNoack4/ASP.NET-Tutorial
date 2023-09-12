using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public string Id { get; set; } = "";
        public string Maker { get; set; } = "";

        [JsonPropertyName("img")]
        public string Image { get; set; } = "";
        public string Url { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int[] Ratings { get; set; } = new int[0];

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }

        public Product(string id, string maker, string image, string url, string title, string description, int[] ratings)
        {
            Id = id;
            Maker = maker;
            Image = image;
            Url = url;
            Title = title;
            Description = description;
            Ratings = ratings;
        }
    }
}
