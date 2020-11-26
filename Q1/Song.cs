using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }

       public Song(string title,string artist,double duration, Genre musicGene)
        {
            title = Title;
            artist = Artist;
            duration = Duration ;
            musicGene = MusicGenre;
        }

        public Song(string title, string artist) : this(title,artist, 0, Genre.Other) { }

        public Song() : this("unknown", "unknown") { }

        public override string ToString()
        {
            return string.Format($"{Title}{Artist}{Duration}{MusicGenre}");
        }

    }
    public enum Genre { Rock,Pop,Dance,Other }
}
