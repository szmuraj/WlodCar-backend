using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Rejestracja DbContext w kontenerze DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dodanie usług MVC
builder.Services.AddControllers();

var app = builder.Build();

// Włączenie routingu i mapowanie kontrolerów
app.UseRouting();
app.MapControllers();

// Uruchomienie aplikacji
app.Run();