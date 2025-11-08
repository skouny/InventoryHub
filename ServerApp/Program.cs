var builder = WebApplication.CreateBuilder(args);

// Add CORS services - Generated with Copilot assistance (Activity 1)
// Allows cross-origin requests from the Blazor WebAssembly client
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add response caching for performance optimization (Activity 4)
// Copilot suggested this to reduce server load and improve response times
builder.Services.AddResponseCaching();

// Add output caching for better performance
builder.Services.AddOutputCache();

var app = builder.Build();

// Enable CORS
app.UseCors("AllowBlazorClient");

// Enable response caching middleware
app.UseResponseCaching();

// Enable output caching middleware
app.UseOutputCache();

// Updated endpoint to /api/productlist with nested category structure (Activity 3)
// Copilot helped structure the JSON response to include nested category objects
// Cache responses for 60 seconds to minimize server load (Activity 4 - Performance optimization)
app.MapGet("/api/productlist", () =>
{
    // Sample product data with nested categories
    // In a production environment, this would come from a database
    return Results.Json(new[]
    {
        new
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new { Id = 101, Name = "Electronics" }
        },
        new
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new { Id = 102, Name = "Accessories" }
        }    });
}).CacheOutput(policy => policy.Expire(TimeSpan.FromSeconds(60)));

app.Run();
