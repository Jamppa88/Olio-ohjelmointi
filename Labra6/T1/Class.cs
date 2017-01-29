using System;
using System.Collections.Generic;


namespace JAMK_IT
{
    class CD
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<Track> Tracks = new List<Track>();
        public CD(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
    }
    class Track
    {
        public string Name { get; set; }
        private string length;

        public string Length
        {
            get { return length; }
            set { length = value; }
        }

        public Track(string name, int min, int sec)
        {
            Name = name;
            Length = String.Format("{0}:{1}",min, (sec > 9)?sec.ToString():"0" + sec.ToString());
        }
    }
}
