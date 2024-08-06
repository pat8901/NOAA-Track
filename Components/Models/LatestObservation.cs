using System.Text.Json.Serialization;

namespace NOAA_Track.Models
{
    public class LatestObservationResponse
    {
        public LatestObservationGeometry? geometry { get; set; }
        public LatestObservationProperties? properties { get; set; }
    }

    public class LatestObservationGeometry
    {
        public List<double>? coordinates { get; set; }
    }

    public class LatestObservationProperties
    {
        public string? timestamp { get; set; }
        public string? rawMessage { get; set; }
        public string? textDescription { get; set; }
        public LatestObservationPropertiesTemperature? temperature { get; set; }
        public LatestObservationPropertiesWindSpeed? windSpeed { get; set; }
        public LatestObservationPropertiesBarometricPressure? barometricPressure { get; set; }
        public LatestObservationPropertiesRelativeHumidity? relativeHumidity { get; set; }
        public LatestObservationPropertiesHeatIndex? heatIndex { get; set; }
    }

    public class LatestObservationPropertiesTemperature
    {
        public string? unitCode { get; set; }
        public int value { get; set; }
    }

    public class LatestObservationPropertiesWindSpeed
    {
        public string? unitCode { get; set; }
        public double value { get; set; }
    }

    public class LatestObservationPropertiesBarometricPressure
    {
        public string? unitCode { get; set; }
        public int value { get; set; }
    }

    public class LatestObservationPropertiesRelativeHumidity
    {
        public string? unitCode { get; set; }
        public double value { get; set; }
    }

    public class LatestObservationPropertiesHeatIndex
    {
        public string? unitCode { get; set; }
        public double value { get; set; }
    }
}