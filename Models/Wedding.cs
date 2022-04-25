using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Wedding_Planner.CustomValidators;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Wedder One")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        public string WedderOne { get; set; }
        
        [Required(ErrorMessage = "is required")]
        [Display(Name = "Wedder Two")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]

        public string WedderTwo { get; set; }

        [FutureDate]
        [Required(ErrorMessage = "is required")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Wedding Address")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]

        public string WeddingAddress { get; set; }

        [Display(Name = "Image Url")]
        public string ImgUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User Planner { get; set; }

        public List<WeddingGuestRSVP> WeddingGuestRSVPd { get ; set; }
    }
}