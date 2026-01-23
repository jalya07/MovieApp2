using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.DAL.Data;
using MovieAppBLL.Services;

var serviceCollection = new ServiceCollection();
serviceCollection.AddDbContext<MovieAppDbContext>(options =>
{
    options.UseSqlServer("Server=localhost,1433;Database=MovieApp;User Id=sa;Password=CodeWithArjun123;TrustServerCertificate=True;");
});
serviceCollection.AddScoped<DirectorService>();
var serviceProvider = serviceCollection.BuildServiceProvider();
using var context = serviceProvider.GetRequiredService<MovieAppDbContext>();
var directorService = serviceProvider.GetRequiredService<DirectorService>();
//var directors = await directorService.GetAllDirectorAsync();
//foreach (var director in directors)
//    Console.WriteLine($"Director:{director.Name}");
//var directors = await directorService.GetAllDirectorBySearchAsync("a");
//foreach(var item in directors)
//    Console.WriteLine(item.Name);