using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Planner.Models
{
    public class WeddingGuestRSVP
    {
        [Key]
        public int WeddingGuestRSVPId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User User { get; set; }
        public int WeddingId { get; set;}

        public Wedding Wedding { get; set; }
    }
}