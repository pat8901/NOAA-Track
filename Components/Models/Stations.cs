using System.Text.Json.Serialization;

namespace NOAA_Track.Models
{

    public class StationApiResponse
    {
        // [JsonPropertyName("@context")]
        // public ContextItem Context { get; set; }
        public string type { get; set; }
        public List<Feature> features { get; set; }
    }

    public class Feature
    {
        public PropertiesItem properties { get; set; }
    }

    public class PropertiesItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string timeZone { get; set; }
    }
}