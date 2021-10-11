using System;
using PointOfInterest;

namespace Main {
    class Program {
        static void Main(string[] str) {
            // defining location objects
            var EffeilTower = new Location("Effeil Tower", 48.8583701, 2.2922926);
            var GreatSphinxOfGiza = new Location("Great Sphinx of Giza", 29.9755267, 31.1367819);
            var StatueOfLiberty = new Location("Statue of Liberty", 40.6870048, -74.0671799);

            // using methods on objects
            Console.WriteLine(EffeilTower.GetGoogleMapsUrl());
            Console.WriteLine(GreatSphinxOfGiza.ToString());
            Console.WriteLine(EffeilTower.GetDistance(StatueOfLiberty));
        }
    }
}
