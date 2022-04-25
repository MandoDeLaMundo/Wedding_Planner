using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Planner.Models;
using Microsoft.EntityFrameworkCore;

namespace Wedding_Planner.Models
{
    public class WeddingPlannerContext : DbContext
    {
        public WeddingPlannerContext (DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<WeddingGuestRSVP> WeddingGuestRSVPs { get; set; }
    }
}