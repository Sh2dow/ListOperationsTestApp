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