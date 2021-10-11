using System;

namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        public int BuildYear { get; set; }


        public override string ToString()
        {
            return string.Format($"{Name} is a historical monument built in {BuildYear}");
        }


        public HistoricalMonument()
        {
        }

        public HistoricalMonument(string name, double latitude, double longitude, int buildYear)
        {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
            BuildYear = buildYear;
        }
    }
}