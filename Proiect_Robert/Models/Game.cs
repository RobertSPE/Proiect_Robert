using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proiect_Robert.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Denumire { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Genul { get; set; }

        [RangeAttribute(1, 10)]
        public decimal Rating { get; set; }
        [Required]
        
        public string SiteUrl { get; set; }
        [Required]

        public DateTime DataPublicarii { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required]
        [Display(Name = "Imagine")]
        public string ImageUrl { get; set; }
        
    }


}
