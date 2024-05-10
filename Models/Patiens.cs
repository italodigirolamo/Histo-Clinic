using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Histo_Clinic.Models
{
    public class Patiens
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Identificador ID/RUT/Passport")]
        public required string IdDocument { get; set; }
        [Required]
        [Display (Name = "First Name")]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Gender Identity")]
        public string? Gender_Identity { get; set; }

        [Display(Name = "Birthday Date")]
        public string? DateBirth { get; set;}

        [Display(Name = "Email Adress")]
        public required string  Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Display(Name = "Main Adress")]
        public string Adress { get; set; } = string.Empty;

        [Display(Name = "City")]
        public string City { get; set; } = string.Empty;

        [Display(Name = "State")]
        public string State { get; set; } = string.Empty;


        [Display(Name = "Emergency Contact")]
        public required string? EmergContact { get; set; }

        [Display(Name = "Photo")]
        public required string? Photo { get; set; }
    }
}
