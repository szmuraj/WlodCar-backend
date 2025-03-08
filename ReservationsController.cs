using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ReservationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Metoda do tworzenia rezerwacji
    [HttpPost]
    public async Task<IActionResult> CreateReservation([FromBody] ReservationRequest request)
    {
        var car = await _context.Cars.FindAsync(request.CarId);
        if (car == null || !car.IsAvailable)
        {
            return BadRequest("Car is not available.");
        }

        var reservation = new Reservation
        {
            CarId = request.CarId,
            CustomerId = request.CustomerId,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
            TotalPrice = car.PricePerDay * (request.EndDate - request.StartDate).Days
        };

        _context.Reservations.Add(reservation);
        car.IsAvailable = false;  // Oznacz samochód jako niedostępny
        await _context.SaveChangesAsync();

        return Ok(reservation);
    }
}
