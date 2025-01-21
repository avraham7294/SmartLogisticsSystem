using Microsoft.EntityFrameworkCore;
using SmartLogisticsSystem.Data;
using SmartLogisticsSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Add MVC controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext for SmartLogisticsDbContext.
builder.Services.AddDbContext<SmartLogisticsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register HttpClient service for external API calls.
builder.Services.AddHttpClient();

// Register custom services.
builder.Services.AddTransient<PackageApiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable HTTPS redirection.
app.UseHttpsRedirection();

app.MapControllers(); // Map controller routes

// Run the application.
app.Run();
