using System.ComponentModel.DataAnnotations;

namespace ListOperationsTestApp.Models
{
    public class DetailModel
    {
        [Required]
        [Display(Name = "Detail Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Number")]
        public int Number { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Allowed")]
        public bool Allowed { get; set; }

        [Required]
        [Display(Name = "Price")]
        [RegularExpression(@"^\$?\-?([1-9]{1}[0-9]{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))$|^\-?\$?([1-9]{1}\d{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))$|^\(\$?([1-9]{1}\d{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))\)$", ErrorMessage = "The value must be in currency format ")]
        [StringLength(12)]
        public decimal Price { get; set; }

        public DetailModel() { }

        public DetailModel(int number, string name, bool allowed, decimal price)
        {
            Number = number;
            Name = name;
            Allowed = allowed;
            Price = price;
        }
    }
}