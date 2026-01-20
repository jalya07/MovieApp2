using MovieApp.DAL.Models;

namespace MovieAppBLL.Services
{
    public interface IDirectorService
    {
        void AddDirector(Director director);
        Task AddDirectorAsync(Director director);
        Task<List<Director>> GetAllDirectorAsync();
        Task<List<Director>> GetAllDirectorBySearchAsync(string value);
        List<Director> GetAllDirectors();
        List<Director> GetAllDirectorsBySearch(string value);
        Director? GetDirectorById(int id);
        Task<Director?> GetDirectorByIdAsync(int id);
    }
}