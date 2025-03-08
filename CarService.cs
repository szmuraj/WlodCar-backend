using System.Threading.Tasks;
using System;

public class CarService
{
    private readonly ApplicationDbContext _context;

    public CarService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Sprawdzanie dostępności samochodu
    public async Task<bool> IsCarAvailable(int carId, DateTime startDate, DateTime endDate)
    {
        var reservations = await _context.Reservations
            .Where(r => r.CarId == carId)
            .Where(r => (r.StartDate < endDate && r.EndDate > startDate))
            .ToListAsync();

        return !reservations.Any();
    }
}