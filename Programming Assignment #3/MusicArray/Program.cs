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

            public void setArtist(string artist)
            {
                Artist = artist;
            }

            public void setAlbum(string album)
            {
                Album = album;
            }

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(int length)
            {
                Length = length;
            }
            public Genre? setGenre(char g)
            {

                switch (g)
                {
                    case 'R':
                        Genre = Program.Genre.Rock;
                        break;
                    case 'M':
                        Genre = Program.Genre.Metal;
                        break;
                    case 'P':
                        Genre = Program.Genre.Punk;
                        break;
                    case 'K':
                        Genre = Program.Genre.KPop;
                        break;
                    case 'B':
                        Genre = Program.Genre.Blues;
                        break;
                }

                return Genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of the song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album name?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("How many seconds in the song?");
                    collection[i].setLength(int.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("R - rock\nM - metal\nP - punk\nK - Kpop\nB - Blues");
                    collection[i].setGenre(char.ToUpper(char.Parse(Console.ReadLine())));
                    Console.WriteLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}