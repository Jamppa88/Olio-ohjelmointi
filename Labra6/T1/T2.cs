using System;


namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("Mercury Falling", "Sting");
            Track track = new Track("The Hounds of Winter", 5, 27);
            cd.Tracks.Add(track);
            
            track = new Track("I Hung My Head", 4, 40);
            cd.Tracks.Add(track);
            track = new Track("Let Your Soul Be Your Pilot", 6, 41);
            cd.Tracks.Add(track);
            track = new Track("I Was Brought To My Senses", 5, 48);
            cd.Tracks.Add(track);
            track = new Track("You Still Touch Me", 3, 46);
            cd.Tracks.Add(track);
            track = new Track("I'm So Happy I Can't Stop Crying", 3, 56);
            cd.Tracks.Add(track);
            track = new Track("All Four Seasons", 4, 28);
            cd.Tracks.Add(track);
            track = new Track("Twenty Five To Midnight", 4, 7);
            cd.Tracks.Add(track);
            track = new Track("La Belle Dame Sans Regrets", 5, 17);
            cd.Tracks.Add(track);
            track = new Track("Valparaiso", 5, 27);
            cd.Tracks.Add(track);
            track = new Track("Lithium Sunset", 2, 38);
            cd.Tracks.Add(track);

            PrintData(cd);
            Console.ReadKey();
        }

        static void PrintData(CD cd)
        {
            Console.WriteLine("CD Data:");
            Console.WriteLine("- name: " + cd.Title);
            Console.WriteLine("- artist: " + cd.Artist);
            Console.WriteLine("- songs:");
            foreach (Track track in cd.Tracks)
            {
                Console.WriteLine("  - {0}, {1}", track.Name, track.Length);
            }
        }
    }
}
