using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_System
{
    public class DataBaseContext: DbContext
    {
        private readonly string _path = @"G:\sem 3 UOR\Sale_System\POSDatabase.db";
        //private readonly string _path = System.IO.Path.Combine(Directory.GetCurrentDirectory()) + "\\POSDatabase.db";
        protected override void
        
        OnConfiguring(DbContextOptionsBuilder optionBuilder)
        => optionBuilder.UseSqlite($"Data Source={_path}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(nameof(User.CompanyId));

            modelBuilder.Entity<Admin>()
                .HasKey(nameof(Admin.AdminId));
            modelBuilder.Entity<StoreData>()
               .HasKey(nameof(StoreData.ProductId));
        }

        public DbSet<StoreData> Store_Database { get; set; }
        public DbSet<User> User_Database { get; set; }
        public DbSet<Admin> Admin_Database { get; set; }
    }
}
