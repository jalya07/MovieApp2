using System;
using Microsoft.EntityFrameworkCore;
using MovieApp.DAL.Data;
using MovieApp.DAL.Models;

namespace MovieAppBLL.Services
{
	public class DirectorService
	{
		private readonly MovieAppDbContext movieAppDbContext;
		public DirectorService(MovieAppDbContext movieAppDbContext)
		{
			movieAppDbContext = movieAppDbContext;
		}
		public List<Director> GetAllDirectors() =>
			movieAppDbContext.Directories.ToList();
		public async Task<List<Director>> GetAllDirectorAsync() =>
			await movieAppDbContext.Directories.ToListAsync();
		public Director? GetDirectorById(int id) =>
			movieAppDbContext.Directories.FirstOrDefault(d => d.Id == id);
		public async Task<Director?> GetDirectorByIdAsync(int id) =>
			await movieAppDbContext.Directories.FirstOrDefaultAsync(d => d.Id == id);
		public List<Director> GetAllDirectorsBySearch(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new Exception();
			return movieAppDbContext.Directories
				.Where(d => d.Name.Contains(value, StringComparison.OrdinalIgnoreCase))
				.ToList();
		}
		public async Task<List<Director>> GetAllDirectorBySearchAsync(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new Exception();
			return await movieAppDbContext.Directories
				.Where(d => d.Name.Contains(value, StringComparison.OrdinalIgnoreCase))
				.ToListAsync();
		}
		public void AddDirector(Director director)
		{
			if (director == null)
				throw new Exception();
			movieAppDbContext.Directories.Add(director);
			movieAppDbContext.SaveChanges();
		}
        public async Task AddDirectorAsync(Director director)
        {
            if (director == null)
                throw new Exception();
            await movieAppDbContext.Directories.AddAsync(director);
            await movieAppDbContext.SaveChangesAsync();
        }
    }
}
