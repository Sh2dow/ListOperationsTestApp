using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListOperationsTestApp.Models
{
    public class OrderViewModel
    {
        [Required]
        [Display(Name = "Order Id")]
        public int Id { get; set; }

        [Display(Name = "Total Cost")]
        public decimal TotalCost
        {
            get
            {
                var sum = default(decimal);
                DetailsList.ForEach(dcm =>
                {
                    dcm.FindAll(d => d.Allowed).ForEach(d =>
                    sum += d.Price);
                });
                return sum;
            }
        }

        public List<DetailsCollectionModel> DetailsList { get; set; }

        public OrderViewModel()
        {
            DetailsList = new List<DetailsCollectionModel>();
        }
    }
}