using ContosoCrafts.WebSite.Services;

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          _ = policy.WithOrigins("http://example.com",
                                              "https://user-images.githubusercontent.com");
                      });
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc().AddRazorRuntimeCompilation();
builder.Services.AddTransient<JsonFileProductService>();
builder.Services.AddControllers();
builder.Services.AddServerSideBlazor();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _ = app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=products}");

app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();
//app.MapGet("/products", (context) =>
//{
//    IEnumerable<Product> products = app.Services.GetService<JsonFileProductService>().GetProducts();
//    string json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
//    return context.Response.WriteAsync(json);
//});

app.Run();