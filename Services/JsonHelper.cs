using BikeStation.Models;
using System;
using System.IO;
using System.Text.Json;

namespace BikeStation.Services
{
    public static class JsonHelper
    {
        public static T ReadJsonFile<T>(string filePath)
        {
            try
            {
                T data;
                // Read json data
                string text = File.ReadAllText(filePath);
                // De-serialize to object
                data = JsonSerializer.Deserialize<T>(text);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public static void AddBikeToJsonFile(BikeModel model,string filePath)
        {
            try
            {
                // Read existing json data
                var jsonData = System.IO.File.ReadAllText(filePath);
                // De-serialize to object or create new list
                var data = JsonSerializer.Deserialize<Bikes>(jsonData);

                // Add any new bikes
                data.data.bikes.Add(new BikeModel()
                {
                    bike_id = model.bike_id,
                    station_id = model.station_id,
                    name = model.name,
                    lon = model.lon,
                    lat = model.lat,
                    is_disabled = model.is_disabled,
                    is_reserved = model.is_reserved
                });

                // Update json data string
                jsonData = JsonSerializer.Serialize(data);
                System.IO.File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
