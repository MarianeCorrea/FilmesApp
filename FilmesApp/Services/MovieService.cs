using FilmesApp.Models;
using System.Net.Http;
using System.Text.Json;

public class MovieService
{
    private readonly HttpClient _client = new HttpClient();
    private const string apiKey = "8fa2f26c";

    public async Task<Movie> GetMovieAsync(string title)
    {
        var response = await _client.GetStringAsync($"http://www.omdbapi.com/?t={title}&apikey={apiKey}");
        return JsonSerializer.Deserialize<Movie>(response);
    }
}