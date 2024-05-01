using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CZ.Infrastructure
{
    public class EFCZContext : DbContext
    {
        public EFCZContext() { }
        public EFCZContext(DbContextOptions<EFCZContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<WaitingClient> WaitingLists { get; set; }
        public DbSet<Daytime> Daytimes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=./;Initial Catalog=CZ.HipodromoProject;Integrated Security=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Daytime>(d =>
            //{
            //    d.HasNoKey();
            //});

            // ConfigureUniqueIndexes(modelBuilder);
            // ConfigureDefaultValues(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureDefaultValues(ModelBuilder modelBuilder)
        {
        }

        // public override int SaveChanges()
        // {
        //     // var entities = ChangeTracker.Entries()
        //     //     .Where(x => x.Entity is KeyEntity && (x.State == EntityState.Added));
        //     // 
        //     // foreach (var entity in entities)
        //     //     ((KeyEntity)entity.Entity).Key = Guid.NewGuid().ToString();
        //     // 
        //     // return base.SaveChanges();
        // }

        private void ConfigureUniqueIndexes(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Order>()
            //     .HasIndex(x => x.Key);
        }
    }
}
