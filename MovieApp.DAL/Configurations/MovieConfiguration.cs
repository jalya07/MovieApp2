using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.DAL.Models;

namespace MovieApp.DAL.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>

    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(m => m.ReleaseYear)
                .IsRequired();
            builder.Property(m => m.Duration)
                .IsRequired();
            builder.Property(m => m.Imdb)
                .IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.HasOne(m => m.Director)
                .WithMany(d => d.Movies)
                .HasForeignKey(m => m.DirectorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData
                (
                    new Movie
                    {
                        Id = 1,
                        Title = "Inception",
                        ReleaseYear = new DateTime(2010, 7, 16),
                        Description = "A thief who steals corporate secrets",
                        Duration = 148,
                        Imdb = 8.8m,
                        DirectorId = 1
                    },
                    new Movie
                    {
                        Id = 2,
                        Title = "The Dark Knight",
                        ReleaseYear = new DateTime(2008, 7, 18),
                        Description = "When the menace know as the Joker emerges from..",
                        Duration = 152,
                        Imdb = 9.0m,
                        DirectorId = 2
                    }
                );

        }
    }
}

