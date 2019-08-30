using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models
{
    public class ProductReview
    {
        
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(1, 5)]
        public int Review { get; set; }
        public virtual Product product {get; set;}
        public virtual ApplicationUser User { get; set; }
    }
}
