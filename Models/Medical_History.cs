using System.ComponentModel.DataAnnotations;

namespace Histo_Clinic.Models
{
    public class Medical_History
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Médical treatment?")]
        public required bool Medical_treatment { get; set; }

        public required bool Medications { get; set; }
        [Required]
        public bool Allergies { get; set; }

    }
}
