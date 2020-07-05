using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAPI.Models.Entities
{
    [Table("Hospital", Schema = "pmwebsit_HospitalDB")]
    public class Hospital
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int HospitalID { get; set; }
        [StringLength(maximumLength: 250, ErrorMessage = "Hospital name can't be greather than 250 characters!")]
        [Required(ErrorMessage = "Name can't be null!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Level zero visiting time is required")]
        public int levelZeroVisitingTime { get; set; }
        [Required(ErrorMessage = "Level one visiting time is required")]
        public int levelOneVisitingTime { get; set; }
        [Required(ErrorMessage = "Level two visiting time is required")]
        public int levelTwoVisitingTime { get; set; }
        [Required(ErrorMessage = "Level three visiting time is required")]
        public int levelThreeVisitingTime { get; set; }
        [Required(ErrorMessage = "Level four visiting time is required")]
        public int levelFourVisitingTime { get; set; }
    }
}
