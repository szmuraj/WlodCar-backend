using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WlodCarBackend.Models;
public class Car
{
    [Key]
    public int Id { get; set; }

    public required string Make { get; set; } = null!;  // Marka samochodu
    public required string Model { get; set; } = null!; // Model samochodu
    public required string Color { get; set; } = null!; // Kolor samochodu

    [Display(Name = "Rodzaj paliwa")]
    [Column(TypeName = "enum('Benzyna', 'Diesel', 'Elektryczny', 'Hybryda')")]
    public required string Fuel { get; set; }

    [Display(Name = "Skrzynia biegów")]
    [Column(TypeName = "enum('Manualna', 'Automatyczna')")]
    public required string Gearbox { get; set; }

    [Display(Name = "Typ nadwozia")]
    [Column(TypeName = "enum('Sedan', 'Kombi', 'SUV', 'Coupe', 'Kabriolet', 'Hatchback')")]
    public required string Body { get; set; } = null!;

    [Display(Name = "Napęd")]
    [Column(TypeName = "enum('Przedni', 'Tylny', '4x4')")]
    public required string Drive { get; set; }

    [Display(Name = "Ilość miejsc")]
    [Column(TypeName = "tinyint")]
    public required int Seats { get; set; }

    [Display(Name = "Ilość drzwi")]
    [Column(TypeName = "tinyint")]
    public required int Doors { get; set; }

    [Display(Name = "Pojemność bagażnika")]
    [Column(TypeName = "tinyint")]
    public required int TrunkCapacity { get; set; }

    [Display(Name = "Pojemność silnika")]
    [Column(TypeName = "tinylint")]
    public required int EngineCapacity { get; set; }

    [Display(Name = "Moc silnika")]
    [Column(TypeName = "tinylint")]
    public required int Power { get; set; }
    public required string? Image { get; set; } // Zdjęcie samochodu
    public string? Description { get; set; } // Opis samochodu

    [Display(Name = "Rok produkcji")]
    [Column(TypeName = "year")]
    public required int Year { get; set; }

    [Display(Name = "Numer rejestracyjny")]
    public string RegistrationNumber { get; set; } = null!;

    [Display(Name = "Numer VIN")]
    [Column(TypeName = "varchar(17)")]
    public required string VIN { get; set; } = null!;

    [Display(Name = "Dostępność")]
    [Column(TypeName = "bool")]
    public required bool IsAvailable { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(3, 2)")]
    public required decimal PricePerDay { get; set; }

    
    public required decimal GPSLatitude { get; set; }
    public required decimal GPSLongitude { get; set; }
}
