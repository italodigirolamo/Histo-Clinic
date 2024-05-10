using System.ComponentModel.DataAnnotations;

namespace Histo_Clinic.Models
{
    public class FamilyHistory
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Name of Disease")]
        public required string Disease { get; set; }

    }

}
