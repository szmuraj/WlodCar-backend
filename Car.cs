using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Car
{
    [Key]
    public int Id { get; set; }

    public string Make { get; set; } = null!;  // Marka samochodu
    public string Model { get; set; } = null!; // Model samochodu
    public string Color { get; set; } = null!; // Kolor samochodu

    [Display(Name = "Rodzaj paliwa")]
    [Column(TypeName = "enum('Benzyna', 'Diesel', 'Elektryczny', 'Hybryda')")]
    public required string Fuel { get; set; }

    [Display(Name = "Skrzynia biegów")]
    [Column(TypeName = "enum('Manualna', 'Automatyczna')")]
    public required string Gearbox { get; set; }

    [Display(Name = "Typ nadwozia")]
    [Column(TypeName = "enum('Sedan', 'Kombi', 'SUV', 'Coupe', 'Kabriolet', 'Hatchback')")]
    public string Body { get; set; } = null!;

    [Display(Name = "Napęd")]
    [Column(TypeName = "enum('Przedni', 'Tylny', '4x4')")]
    public required string Drive { get; set; }

    [Display(Name = "Ilość miejsc")]
    [Column(TypeName = "tinyint")]
    public int Seats { get; set; }

    [Display(Name = "Ilość drzwi")]
    [Column(TypeName = "tinyint")]
    public int Doors { get; set; }

    [Display(Name = "Pojemność bagażnika")]
    [Column(TypeName = "tinyint")]
    public int TrunkCapacity { get; set; }

    [Display(Name = "Pojemność silnika")]
    [Column(TypeName = "tinylint")]
    public int EngineCapacity { get; set; }

    [Display(Name = "Moc silnika")]
    [Column(TypeName = "tinylint")]
    public int Power { get; set; }
    public string? Image { get; set; } // Zdjęcie samochodu
    public string? Description { get; set; } // Opis samochodu

    [Display(Name = "Rok produkcji")]
    [Column(TypeName = "year")]
    public int Year { get; set; }

    [Display(Name = "Numer rejestracyjny")]
    public string RegistrationNumber { get; set; } = null!;

    [Display(Name = "Numer VIN")]
    [Column(TypeName = "varchar(17)")]
    public string VIN { get; set; } = null!;

    [Display(Name = "Dostępność")]
    [Column(TypeName = "bool")]
    public bool IsAvailable { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(3, 2)")]
    public decimal PricePerDay { get; set; }
}
