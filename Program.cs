using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album = new Album();
            album.Title = "Kamikaze";
            album.Artist = "Eminem";

            var book = new Book();
            book.Title = "The Odyssey";
            book.Author = "Homer";

            var movie = new Movie();
            movie.Title = "The Lion King";
            movie.Director = "Walt Disney";

            Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
            Console.WriteLine("Book: " + book.Title + " by " + book.Artist);
            Console.WriteLine("Movie: " + movie.Title + " by " + movie.Artist);

        }
    }
}