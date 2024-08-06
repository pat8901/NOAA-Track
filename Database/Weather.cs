using NOAA_Track.Models;

namespace NOAA_Track.Database
{
    public class Weather
    {
        public int Id { get; set; }
        public string? timestamp { get; set; }
        public string? rawMessage { get; set; }
        public string? textDescription { get; set; }
        // public LatestObservationPropertiesTemperature? temperature { get; set; }
        // public LatestObservationPropertiesWindSpeed? windSpeed { get; set; }
        // public LatestObservationPropertiesBarometricPressure? barometricPressure { get; set; }
        // public LatestObservationPropertiesRelativeHumidity? relativeHumidity { get; set; }
        // public LatestObservationPropertiesHeatIndex? heatIndex { get; set; }
    }
}