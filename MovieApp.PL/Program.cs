using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.DAL.Data;
using MovieAppBLL.Services;

var serviceCollection = new ServiceCollection();
serviceCollection.AddDbContext<MovieAppDbContext>(options =>
{
    options.UseSqlServer("YOUR_CONNECTION_STRING");
});
serviceCollection.AddScoped<DirectorService>();
var serviceProvider = serviceCollection.BuildServiceProvider();
//using var context = serviceProvider.GetRequiredService<MovieAppDbContext>();
var directorService = serviceProvider.GetRequiredService<DirectorService>();
var directors = await directorService.GetAllDirectorAsync();
foreach(var director in directors)
    Console.WriteLine($"Director:{director.Name}");
