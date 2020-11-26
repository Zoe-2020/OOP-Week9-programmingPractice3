using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Song : IComparable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }

       public Song(string artist, string title, double duration, Genre musicGene)
        {
            
             Artist = artist ;
             Title = title;
             Duration = duration  ;
            MusicGenre = musicGene ;
        }

        public Song(string artist,string title) : this(artist, title, 0, Genre.Other) { }

        public Song() : this("unknown", "unknown") { }

        public override string ToString()
        {
            return string.Format($"{Artist}{Title}{Duration}{MusicGenre}");
        }

        public int CompareTo(object other)
        {
            Song that = (Song)other;

            int returnValue = this.Artist.CompareTo(that.Artist);

            if (returnValue == 0)
            {
                returnValue = this.Title.CompareTo(that.Title);
            }
            return returnValue;


        }
    }
    public enum Genre { Rock,Pop,Dance,Other}
}
