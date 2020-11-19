using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public string ReleaseDate { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string StarRating { get; set; }
     
    }
}
