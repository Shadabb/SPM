using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string ProductCode { get; set; }

        [MaxLength(50)]
        public string ReleaseDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Price { get; set; }

        [Required]
        [MaxLength(50)]
        public string StarRating { get; set; }

        [MaxLength(256)]
        public string ImageUrl { get; set; }
    }
}
