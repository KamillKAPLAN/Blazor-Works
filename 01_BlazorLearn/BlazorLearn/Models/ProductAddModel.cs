using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorLearn.Models
{
    public class ProductAddModel
    {
        /* Data Annotation */

        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
