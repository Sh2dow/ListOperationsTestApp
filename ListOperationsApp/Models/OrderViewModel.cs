using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListOperationsApp.Models
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
                    .ForEach(c => c.Movies
                    .ForEach(m => sum += m.Seen ? 1 : 0));
                return sum;
            }
        }
    }
}