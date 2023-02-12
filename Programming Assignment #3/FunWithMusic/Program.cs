using System;
using System.Diagnostics.Metrics;

namespace Songs
{
    class Program
    {
        enum Genre
        {
            Rock,
            Metal,
            Punk,
            KPop,
            Blues,
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, int length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(int length)
            {
                Length = length;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album name?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How many seconds in the song?");
            int tempLength = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine("R - rock\nM - metal\nP - punk\nK - Kpop\nB - Blues");
            Genre tempGenre = Genre.KPop;
            char g = char.ToUpper(char.Parse(Console.ReadLine()));
            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'P':
                    tempGenre = Genre.Punk;
                    break;
                case 'K':
                    tempGenre = Genre.KPop;
                    break;
                case 'B':
                    tempGenre = Genre.Blues;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{music.Display()}");

            Music moreMusic = music;
            Console.WriteLine("What is the next song on the album?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("How many seconds is the song?");
            moreMusic.setLength(int.Parse(Console.ReadLine()));
            Console.WriteLine(moreMusic.Display());

        }
    }
}