// Ignore Spelling: Ballance Pesel REGON

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WlodCarBackend.Models;
public class Customer
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; } = null!;
    public required string LastName { get; set; } = null!;

    [Display(Name = "Data urodzenia")]
    [DataType(DataType.Date)]
    public DateTime? BirthDate { get; set; }

    [Display(Name = "Data rejestracji")]
    [DataType(DataType.Date)]
    public required DateTime RegistrationDate { get; set; } = DateTime.Now;

    [Display(Name = "Data ostatniego logowania")]
    [DataType(DataType.Date)]
    public DateTime LastLoginDate { get; set; } = DateTime.Now;

    [Display(Name = "e-mail")]
    [DataType(DataType.EmailAddress)]
    public required string Email { get; set; } = null!;

    [Display(Name = "Numer telefonu")]
    [DataType(DataType.PhoneNumber)]
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }

    [Display(Name = "Numer PESEL")]
    [Column(TypeName = "int(11)")]
    public string? Pesel { get; set; }

    [Display(Name = "Numer NIP")]
    [Column(TypeName = "int(10)")]
    public int? NIP { get; set; }

    [Display(Name = "Nazwa firmy")]
    public string? CompanyName { get; set; }

    [Display(Name = "Numer REGON")]
    [Column(TypeName = "int(9)")]
    public int? REGON { get; set; }

    [Display(Name = "Punkty lojalnościowe")]
    public int Points { get; set; }

    [Display(Name = "Numer konta bankowego")]
    [Column(TypeName = "int(26)")]
    public string? BankAccountNumber { get; set; }

    public string? IdCardNumber { get; set; } // Numer dowodu osobistego lub paszportu

    [Display(Name = "Numer prawa jazdy")]
    public string? DrivingLicenseNumber { get; set; }

    [Display(Name = "Data wydania prawa jazdy")]
    [DataType(DataType.Date)]
    public DateTime? DrivingLicenseIssueDate { get; set; }

    [Display(Name = "Data ważności prawa jazdy")]
    [DataType(DataType.Date)]
    public DateTime? DrivingLicenseExpirationDate { get; set; }

    [Display(Name = "Typ klienta")]
    [Column(TypeName = "enum('Osoba prywatna', 'Firma')")]
    public required string CustomerType { get; set; }

    [Display(Name = "Zdjęcie profilowe")]
    public string? ProfilePicture { get; set; }

    [Display(Name = "Zdjęcie dowodu osobistego")]
    public string? IdCardPicture { get; set; }

    [Display(Name = "Zdjęcie prawa jazdy")]
    public string? DrivingLicensePicture { get; set; }
    public required string Login { get; set; } = null!;

    [Display(Name = "Hasło")]
    [DataType(DataType.Password)]
    public required string Password { get; set; } = null!;

    [Display(Name = "Saldo")]
    [DataType(DataType.Currency)]
    public int Ballance { get; set; }

    [Display(Name = "Zablokowane konto")]
    [Column(TypeName = "bool")]
    public required bool IsBlocked { get; set; }
}