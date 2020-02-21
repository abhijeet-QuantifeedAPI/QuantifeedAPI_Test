using Microsoft.EntityFrameworkCore;
using QuantifeedWebAPI.Models;
using QuantifeedWebAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantifeedWebAPI.Data
{
    public class QuantifeedDbContext : DbContext
    {
        public QuantifeedDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
