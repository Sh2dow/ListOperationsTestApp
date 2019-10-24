using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieCollectionApp.ViewModels.Models
{
    public class MovieCollectionViewModel
    {
        public MovieCollectionViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }
        public List<CategoryViewModel> Categories { get; set; }

        [Key]
        [Display(Name = "Movie Collection Id")]
        public int Id { get; set; }

        [Display(Name = "Total Seen")]
        public int TotalSeen
        {
            get
            {
                var sum = default(int);
                Categories
                    .ForEach(c => sum += c.Movies
                    .FindAll(m => m.Seen).Count);
                return sum;
            }
        }
    }
}