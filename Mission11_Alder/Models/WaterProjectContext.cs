using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WaterProjectReal.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext(DbContextOptions<WaterProjectContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}