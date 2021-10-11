using System;

namespace PointOfInterest {
    public class Location {
        // constructors
        public Location(string name, double latitude, double longitude) {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
        // properties
        public string Name;
        public double Latitude;
        public double Longitude;
        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
        // methods
        public string GetGoogleMapsUrl() {
            return String.Format("https://www.google.com/maps/place/{0}/@{1},{2},15z/", Name.Replace(" ", "+"), Latitude, Longitude);
        }
        public override string ToString() {
            return String.Format("{0} (Lat={1}, Long={2})", Name, Latitude, Longitude);
        }
        public int GetDistance(Location other) {
            return Convert.ToInt32(111.18957696 * 180 / Math.PI * (Math.Acos(Math.Sin(Math.PI / 180 * Latitude) * Math.Sin(Math.PI / 180 * other.Latitude) +
                Math.Cos(Math.PI / 180 * Latitude) * Math.Cos(Math.PI / 180 * other.Latitude) * Math.Cos(Math.PI / 180 * (Longitude - other.Longitude)))));
        }
    }
}
