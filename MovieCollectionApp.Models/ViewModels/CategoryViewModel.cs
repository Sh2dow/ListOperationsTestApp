using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieCollectionApp.ViewModels.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Movies = new List<MovieViewModel>();
        }

        [Key]
        [Display(Name = "Category Id")]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public List<MovieViewModel> Movies { get; set; }
    }
}