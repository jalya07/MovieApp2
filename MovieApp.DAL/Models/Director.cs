using System;
namespace MovieApp.DAL.Models
{
	public class Director:BaseEntity
	{
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string? City { get; set; } = null!;
        public int Age { get; set; }

        public List<Movie> Movies { get; set; }
        public Director()
        {
            Movies = new List<Movie>();
        }
    }
}

