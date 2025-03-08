using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WlodCarBackend.Models;
public class Reservation
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Car")]
    public required int CarId { get; set; } // Powiązanie z samochodem
    public required Car Car { get; set; }

    [ForeignKey("Customer")]
    public required int CustomerId { get; set; } // Powiązanie z klientem
    public required Customer Customer { get; set; }

    [Display(Name = "Data rozpoczęcia")]
    [DataType(DataType.Date)]
    public required DateTime StartDate { get; set; }

    [Display(Name = "Data zakończenia")]
    [DataType(DataType.Date)]
    public required DateTime EndDate { get; set; }

    [Display(Name = "Cena ostateczna")]
    [Column(TypeName = "decimal(5, 2)")]
    public decimal TotalPrice { get; set; }
}
