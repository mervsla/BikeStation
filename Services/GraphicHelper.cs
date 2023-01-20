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
                //Read stations
                var stationFilePath = @"./DataSource/station.json";
                var stations = JsonHelper.ReadJsonFile<Stations>(stationFilePath);
                //Read bikes
                var bikeFilePath = @"./DataSource/bike.json";
                var bikes = JsonHelper.ReadJsonFile<Bikes>(bikeFilePath);

                var list = new List<GraphicModel>();
                foreach (var item in stations.data.stations)
                {
                    var bikeList = new List<int>();
                    var bikeName = string.Empty;
                    foreach (var itemm in bikes.data.bikes)
                    {
                        if (item.station_id == itemm.station_id)
                        {
                            bikeList.Add(1);
                            bikeName = itemm.name;
                        }
                        else
                            bikeList.Add(0);
                    }
                    var series = new BikeNamesAndCount()
                    {
                        name = bikeName,
                        data = bikeList
                    };

                    list.Add(new GraphicModel()
                    {
                        StationName = item.name,
                        series = series
                    });
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
