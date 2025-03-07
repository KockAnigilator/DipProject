using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=CarMarketDB") { }

        // DbSet для каждый таблицы
        // DbSet для каждой таблицы
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Настройка связи многие-ко-многим между User и Car через Favourite
            modelBuilder.Entity<Favourite>()
                .HasKey(f => new { f.UserId, f.CarId });

            modelBuilder.Entity<Favourite>()
                .HasRequired(f => f.user)
                .WithMany(u => u.Favourites)
                .HasForeignKey(f => f.UserId);

            modelBuilder.Entity<Favourite>()
                .HasRequired(f => f.car)
                .WithMany()
                .HasForeignKey(f => f.CarId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
