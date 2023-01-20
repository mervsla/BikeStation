namespace BikeStation.Models
{
    public class Stations
    {
        public Stations()
        {
            data = new StationData();
        }
        public long last_updated { get; set; }
        public int ttl { get; set; }
        public StationData data { get; set; }
    }
}
