using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace Bangazon.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated {get;set;}

        [RegularExpression("^[a-zA-Z0-9 ]*$")]
        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [RegularExpression("^[a-zA-Z0-9 ]*$")]
        [Required]
        [StringLength(55, ErrorMessage="Please shorten the product title to 55 characters")]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Price per Unit")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(0, 10000, ErrorMessage = "Value for {0} must be less than {2}.")]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string UserId {get; set;}

        [Display(Name = "Local Delivery")]
        public bool LocalDelivery { get; set; }

        [RegularExpression("^[a-zA-Z0-9 ]*$")]
        public string City {get; set;}

        [Display(Name = "Image")]

        public string ImagePath {get; set;}

        public bool Active { get; set; }

        [Display(Name = "Seller")]
        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name="Product Category")]
        public int ProductTypeId { get; set; }

        [Display(Name = "Product Category")]
        public ProductType ProductType { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Product ()
        {
            Active = true;
        }

    }

   
}
