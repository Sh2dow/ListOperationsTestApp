using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ListOperationsTestApp.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }

        public List<DetailModel> Details { get; set; }

        public BaseModel ()
        {
            Details = new List<DetailModel>();
        }

    }
}