using NOAA_Track.Models;

namespace NOAA_Track.Database
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime insertionTime { get; set; }
        public string? timestamp { get; set; }
        public string? rawMessage { get; set; }
        public string? textDescription { get; set; }
        public int? temperature { get; set; }
        public double? windSpeed { get; set; }
        public int? barometricPressure { get; set; }
        public double? relativeHumidity { get; set; }
        public double? heatIndex { get; set; }
    }
}