using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAPI.Models.Entities
{
    [Table("Patient", Schema = "pmwebsit_HospitalDB")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientID { get; set; }
        [Required(ErrorMessage = "Reg time is required")]
        public DateTime RegTime { get; set; }
        [Required(ErrorMessage = "Level is required")]
        public Enums.Level Level { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}", ErrorMessage = "Enter a valid mobile number")]
        public string MobileNumber { get; set; }

        [DefaultValue(false)]
        [Required]
        public string IsVisited { get; set; }

        [ForeignKey("Hospital")]
        public int HospitalID { get; set; }

        public virtual Hospital Hospital { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
