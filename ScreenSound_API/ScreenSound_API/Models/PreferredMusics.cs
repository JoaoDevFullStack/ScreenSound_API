using System.Text.Json;
namespace ScreenSound_API.Models;

internal class PreferredMusics
{
    public string? Name { get; set; }

    public List<Music> PreferredListMusics { get; }

    public PreferredMusics(string name)
    {
        Name = name;
        PreferredListMusics = new List<Music>();
    }

    public void AddMusic(Music music)
    {
        PreferredListMusics.Add(music);
    }

    public void DisplayPreferredMusics()
    {
        Console.WriteLine($"Preferred Musics for {Name}:");
        foreach (var music in PreferredListMusics)
        {
            Console.WriteLine($"- {music.Name} de {music.Artist}");
        }
    }

    public void GenerateJsonArchive()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = PreferredListMusics,
        });
        string fileName = $"{Name}_PreferredMusics.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"JSON archive created: {fileName} {Path.GetFullPath(fileName)}");
    }
}
