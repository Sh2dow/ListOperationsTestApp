using System.ComponentModel.DataAnnotations;

namespace MovieCollectionApp.ViewModels.Models
{
    public class MovieViewModel
    {

        public MovieViewModel() { }

        public MovieViewModel(string name, int year, double? rating)
        {
            Name = name;
            Year = year;
            Rating = rating;
        }

        [Key]
        [Display(Name = "Movie Id")]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        public int Year { get; set; }

        public double? Rating { get; set; }

        public bool Seen { get; set; }
    }
}