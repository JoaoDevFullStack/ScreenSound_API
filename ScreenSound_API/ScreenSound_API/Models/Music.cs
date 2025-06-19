using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

namespace ScreenSound_API.Models;

internal class Music
{
    private string[] tonalities = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonality
    {
        get
        {
            return tonalities[Key];
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Song: {Name}, Artist: {Artist}, Duration: {Duration} ms, Genre: {Genre}, Key: {Tonality}");
    }
}
