using System.Text.Json.Serialization;

namespace NOAA_Track.Models
{
    public class SingleStationApiResponse
    {
        public Geometry geometry { get; set; }
    }
    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }
}