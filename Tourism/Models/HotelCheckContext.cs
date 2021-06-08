using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class HotelCheckContext: DbContext
    {
        public HotelCheckContext(DbContextOptions<HotelCheckContext> options) : base(options) { }
        public DbSet<HotelCheck> HotelChecks { get; set; }
    }
}
