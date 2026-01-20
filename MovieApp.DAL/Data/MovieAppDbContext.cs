using System;
using MovieApp.DAL.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.DAL.Data
{
	public class MovieAppDbContext : DbContext
    {
        public DbSet<Director> Directories { get; set; }

        public DbSet<Movie> Movies { get; set; }

        //public MovieAppDbContext(DbContextOptions options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=MovieApp;User Id=sa;Password=CodeWithArjun123;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieAppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

