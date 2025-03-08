using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Reservation
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Car")]
    public int CarId { get; set; }  // Powiązanie z samochodem
    public required Car Car { get; set; }
    [ForeignKey("Customer")]
    public int CustomerId { get; set; } // Powiązanie z klientem
    public required Customer Customer { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalPrice { get; set; }
}
