namespace NOAA_Track.Models
{
    public class ApiResponse
    {
        public ContextItem @context { get; set; }
        public string @id { get; set; }
        public List<GraphEntry> graph { get; set; }
    }

    public class ContextItem
    {
        public string @version { get; set; }
    }

    public class GraphEntry
    {
        public string @type { get; set; }
        public string stationId { get; set; }
        public string status { get; set; }
        public int activeChannel { get; set; }
        public string message { get; set; }
        public string timestamp { get; set; }
    }
}