using BasicAuthentication.Models;
using System.Text.Json;

namespace BasicAuthentication.Services
{
    public class BeerService : IBeerServices
    {
        const string path = @"C:\Users\Jose Manuel\source\repos\BasicAuthentication\BasicAuthentication\Beers.json";
        public async Task<List<Beer>> Get()
        {
          string content = await File.ReadAllTextAsync(path);
          var beers = JsonSerializer.Deserialize<List<Beer>>(content);
            return beers;
          
        }
    }
}
