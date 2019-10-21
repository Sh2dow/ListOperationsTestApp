using System.ComponentModel.DataAnnotations;

namespace ListOperationsTestApp.Models
{
    public class DetailModel
    {
        [Required]
        [Display(Name = "Id")]
        public int DetailId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Boolean Value")]
        public bool BooleanValue { get; set; }
    }
}