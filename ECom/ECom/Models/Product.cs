using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models
{
    /// <summary>
    /// the product class will hold all the necessaary information for each product. This information will be shown
    /// on the details page for each product. Added data notations to make all the properties required.
    /// </summary>
    public class Product
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Sku { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
