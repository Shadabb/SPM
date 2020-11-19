using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Price { get; set; }

        [Required]
        [MaxLength(50)]
        public string StarRating { get; set; }
    }
}
