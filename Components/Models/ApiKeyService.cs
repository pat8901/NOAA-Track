namespace NOAA_Track.Models
{
    public class ApiKeyService
    {
        public string API_KEY { get; }

        public ApiKeyService(string API_KEY)
        {
            this.API_KEY = API_KEY;
        }
    }
}