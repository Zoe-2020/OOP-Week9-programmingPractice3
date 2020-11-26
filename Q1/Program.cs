using System;
using System.Collections.Generic;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> playlist = new List<Song>();
            Song s1 = new Song("ED SHEERAN", "BEAUTIFUL PEOPLE", 3.15, Genre.Pop);
            Song s2 = new Song("REGARD", "RIDE IT", 3.37, Genre.Dance);
            Song s3 = new Song("TONES & I", "DANCE MONKEY", 4.20, Genre.Dance);
            Song s4 = new Song("POST MALONE", "CIRCLES", 3.25, Genre.Pop);
            Song s5 = new Song("ED SHEERAN", "SOUTH OF THE BORDER", 4.26, Genre.Other);
     


            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);

            Display(playlist);

            

        }
        private static void Display(List<Song> playlist)
        {
            Console.WriteLine("{0,25}{1,25}{2,25}{3,25}","Artist","Title","Duration","Music Genre");

            foreach (Song song in playlist)
            {
                Console.WriteLine($"{song.Artist,25}{song.Title,25}{song.Duration,25}{song.MusicGenre,25}");
            }


        }
    }
}
