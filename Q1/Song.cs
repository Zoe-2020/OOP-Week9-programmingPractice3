using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Song
    {
        public string title { get; set; }
        public string artist { get; set; }
        public double duration { get; set; }

        public Genre MusicGenre { get; set; }

    }
    public enum Genre { Rock,Pop,Dance,Other }
}
