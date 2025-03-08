using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Dodaj usługi do kontenera
builder.Services.AddControllers();

var app = builder.Build();

// Konfiguracja ścieżki obsługi HTTP
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();