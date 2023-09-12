using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using System.Text.Json;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://example.com",
                                              "https://user-images.githubusercontent.com");
                      });
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc().AddRazorRuntimeCompilation();
builder.Services.AddTransient<JsonFileProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapRazorPages();
app.MapGet("/products", (context) =>
{
    IEnumerable<Product> products = app.Services.GetService<JsonFileProductService>().GetProducts();
    string json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
    return context.Response.WriteAsync(json);
});

app.Run();
