using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Access> Accesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=BranchCarManagerDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
