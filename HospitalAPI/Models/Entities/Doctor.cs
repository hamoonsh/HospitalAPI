using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAPI.Models.Entities
{
    [Table("Doctor", Schema = "pmwebsit_HospitalDB")]
    public class Doctor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int DoctorID { get; set; }
        [StringLength(maximumLength: 250, ErrorMessage = "Name can't be greather than 250 characters!")]
        [Required(ErrorMessage = "Name can't be null!")]
        public string Name { get; set; }
        [StringLength(maximumLength: 250, ErrorMessage = "Famile can't be greather than 250 characters!")]
        [Required(ErrorMessage = "Family can't be null!")]
        public string Family { get; set; }
    }
}
