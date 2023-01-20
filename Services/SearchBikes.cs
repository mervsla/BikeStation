using BikeStation.Models;
using System.Collections.Generic;
using System.Linq;

namespace BikeStation.Services
{
    public static class SearchBikes
    {
        public static List<BikeModel> SearchBikesByBikeModel(BikeModel model)
        {
            var list = new List<BikeModel>();
            var bikeFilePath = @"./DataSource/bike.json";
            var bikes = JsonHelper.ReadJsonFile<Bikes>(bikeFilePath);

            list = bikes.data.bikes.Where(x =>
      (model.name == null || x.name?.Contains(model.name) == true) &&
      (model.bike_id == null || x.bike_id?.Contains(model.bike_id) == true) &&
    (model.station_id == null || x.station_id?.Contains(model.station_id) == true) &&
      (model.lon == 0 || x.lon == model.lon) &&
      (model.lat == 0 || x.lat == model.lat)).ToList();

            return list;
        }
    }
}
