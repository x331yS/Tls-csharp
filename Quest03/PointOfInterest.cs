using System;
namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Name { get; set; }

        public static string GoogleMapsUrlTemplate { get { return "https://www.google.com/maps/place/{0}/@{1},{2},15z/"; } }
        public override string ToString() { return string.Format($"{Name} (Lat={Latitude}, Long={Longitude})"); }
        public string GetGoogleMapsUrl() { return string.Format(GoogleMapsUrlTemplate, Name.Replace(' ', '+'),Latitude, Longitude); }
        public int GetDistance(PointOfInterest other)
        {
            double lat1 = other.Latitude;
            double lat2 = Latitude;
            double lon1 = other.Longitude;
            double lon2 = Longitude;
            double rlat1 = Math.PI*lat1/180;
            double rlat2 = Math.PI*lat2/180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI*theta/180;
            double dist =
                Math.Sin(rlat1)*Math.Sin(rlat2) + Math.Cos(rlat1)*
                Math.Cos(rlat2)*Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist*180/Math.PI;
            dist = dist*60*1.1515;
            dist = dist*1.609344;
            int result = Convert.ToInt32(dist);
            return result;
        }
        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            double lat1 = p1.Latitude;
            double lat2 = p2.Latitude;
            double lon1 = p1.Longitude;
            double lon2 = p2.Longitude;
            double rlat1 = Math.PI*lat1/180;
            double rlat2 = Math.PI*lat2/180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI*theta/180;
            double dist =
                Math.Sin(rlat1)*Math.Sin(rlat2) + Math.Cos(rlat1)*
                Math.Cos(rlat2)*Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist*180/Math.PI;
            dist = dist*60*1.1515;
            dist = dist*1.609344;
            int result = Convert.ToInt32(dist);
            return result;
        }

       

        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Longitude =-0.5663056;
            Latitude = 44.854186;
        }
        public PointOfInterest(string name,double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
