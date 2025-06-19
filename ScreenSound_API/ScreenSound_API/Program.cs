using ScreenSound_API.Models;
using System.Text.Json;
using ScreenSound_API.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;

        LINQ.FilterMusicsInCSharp(musics);

        //musics[2].DisplayInfo();
        //LINQ.FilterAllGenres(musics);
        //LinqOrder.OrderByArtist(musics);
        //LINQ.FilterArtistByGenre(musics, "rock");
        //LINQ.FilterMusicByArtist(musics, "Michel Teló");

        //var PreferredMusicsJoao = new PreferredMusics("João");
        //PreferredMusicsJoao.AddMusic(musics[1]);
        //PreferredMusicsJoao.AddMusic(musics[10]);
        //PreferredMusicsJoao.AddMusic(musics[50]);
        //PreferredMusicsJoao.AddMusic(musics[65]);
        //PreferredMusicsJoao.AddMusic(musics[70]);

        //PreferredMusicsJoao.DisplayPreferredMusics();
        //PreferredMusicsJoao.GenerateJsonArchive();
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("Request error: " + e.Message);
    }


}

// Linq é uma biblioteca do C# que permite consultar coleções de dados de forma declarativa, semelhante ao SQL. Ela é usada para manipular e consultar dados em listas, arrays, bancos de dados e outras fontes de dados. A sintaxe do Linq é baseada em expressões lambda e permite realizar operações como filtragem, ordenação, agrupamento e projeção de dados de maneira concisa e legível.