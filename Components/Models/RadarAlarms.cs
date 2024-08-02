using System.Text.Json.Serialization;

namespace NOAA_Track.Models
{
    public class AlarmApiResponse
    {
        [JsonPropertyName("@context")]
        public ContextItem context { get; set; }
        [JsonPropertyName("@id")]
        public required string id { get; set; }
        [JsonPropertyName("@graph")]
        public required List<GraphEntry> Graph { get; set; }
    }

    public class ContextItem
    {
        [JsonPropertyName("@version")]
        public required string Version { get; set; }
    }

    public class GraphEntry
    {
        [JsonPropertyName("@type")]
        public required string type { get; set; }
        public required string stationId { get; set; }
        public required string status { get; set; }
        public required int activeChannel { get; set; }
        public required string message { get; set; }
        public required string timestamp { get; set; }
    }
}
