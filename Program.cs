using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album = new Album("Kamikaze", "Eminem");
            var book = new Book("The Odyssey", "Homer");
            var movie = new Movie("The Lion King", "Walt Disney");

            Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
            Console.WriteLine("Book: " + book.Title + " by " + book.Artist);
            Console.WriteLine("Movie: " + movie.Title + " by " + movie.Artist);

        }
    }
}