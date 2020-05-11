using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorLearn.Models
{
    public class ProductAddModel
    {
        /* Data Annotation : bizim model nesnelerimizin üzerine bir 
         * 'attribute' vasıtasıyla kurallar koyma yöntemidir. 
        */

        [Required(ErrorMessage = "productName zorunludur.")]
        [StringLength(20, ErrorMessage = "productName karakter sayısını aştı(Max 20)")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "description zorunludur.")]
        [StringLength(40, ErrorMessage = "description karakter sayısını aştı(Max 40)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "category zorunludur.")]
        public string CategoryId { get; set; }

    }
}
