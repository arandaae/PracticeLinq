using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameNames = new List<string>
            {
                "Metal Gear Solid",
                "Halo",
                "The Last of Us",
                "Inside",
            };

            var games = videoGameNames.Where(x => x.Length > 0).OrderBy(x => x.Length);
            foreach (var videoGame in games)
            {
                Console.WriteLine(videoGame);
            }
        }
    }
}
