using BikeStation.DataSource;
using BikeStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStation.Services
{
    public static class GraphicHelper
    {
        //Returns bikes count at the stations
        public static List<GraphicModel> GetNumberOfBikesAtStations()
        {
            try
            {
                var stationFilePath = @"./DataSource/station.json";
                var stations = JsonHelper.ReadJsonFile<Stations>(stationFilePath);

                var bikeFilePath = @"./DataSource/bike.json";
                var bikes = JsonHelper.ReadJsonFile<Bikes>(bikeFilePath);

                var list = new List<GraphicModel>();
                foreach (var stationItem in from stationItem in stations.data.stations
                                            from bikeItem in bikes.data.bikes
                                            where stationItem.station_id == bikeItem.station_id
                                            select stationItem)
                {
                    if (!list.Select(x => x.StationId).Contains(stationItem.station_id))
                    {
                        list.Add(new GraphicModel()
                        {
                            StationId = stationItem.station_id,
                            StationName = stationItem.name,
                            BikeCount = 1
                        });
                    }
                    else
                    {
                        list.Where(x => x.StationId == stationItem.station_id).FirstOrDefault().BikeCount++;
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
