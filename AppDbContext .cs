using goverment_app.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace goverment_app
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
