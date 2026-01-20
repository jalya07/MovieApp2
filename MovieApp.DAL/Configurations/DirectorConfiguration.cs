using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.DAL.Models;

namespace MovieApp.DAL.Configurations
{
	public class DirectorConfiguration: IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(d => d.Adress)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(d => d.City)
                .IsRequired(false);
            builder.Property(d => d.Age)
                .IsRequired();

            //seed data
            builder.HasData
                (
                    new Director
                    {
                        Id = 1,
                        Name = "Steve Spielberg",
                        Description = "An American filmarker",
                        Adress = "100 Hollywood",
                        City = "Los Angels",
                        Age = 74
                    },
                    new Director
                    {
                        Id = 2,
                        Name = "Christopher Nolan",
                        Description = "An British-American filmarker",
                        Adress = "200 Hollywood",
                        City = "London",
                        Age = 50
                    }
                );
        }
    }
}

