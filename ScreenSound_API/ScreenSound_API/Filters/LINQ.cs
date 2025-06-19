using ScreenSound_API.Models;

namespace ScreenSound_API.Filters;

internal class LINQ
{
    public static void FilterAllGenres(List<Music> musics)
    {
        var allGenres = musics.Select(genres => genres.Genre).Distinct().ToList();
        foreach (var genre in allGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistByGenre(List<Music> musics, string genre)
    {
        var artistByGenre = musics.Where(music => music.Genre!.Contains(genre)).Select(music => music.Artist).Distinct().ToList();
        Console.WriteLine($"Artists in the genre {genre}:");
        foreach (var artist in artistByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicByArtist(List<Music> musics, string artist)
    {
        var musicByArtist = musics.Where(music => music.Artist!.Equals(artist)).ToList();
        Console.WriteLine($"Songs by {artist}:");
        foreach (var music in musicByArtist)
        {
            Console.WriteLine($"- {music.Name}");
        }
    }

    internal static void FilterMusicsInCSharp(List<Music> musics)
    {
        var musicsInCSharp = musics.Where(music => music.Tonality.Equals("C#"))
            .Select(music => music.Name)
            .ToList();
       Console.WriteLine("Songs in C#:");
        foreach (var music in musicsInCSharp)
        {
            Console.WriteLine($"- {music}");
        }
    }
}
