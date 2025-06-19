using ScreenSound_API.Models;


namespace ScreenSound_API.Filters
{
    internal class LinqOrder
    {
        public static void OrderByArtist(List<Music> musics)
        {
            var atistOrdered = musics.OrderBy(musics => musics.Artist).Select(musics => musics.Artist).Distinct().ToList();
            foreach (var artist in atistOrdered)
            {
                Console.WriteLine($"- {artist}");
            }
        }
    }
}
