using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Repositories
{
    public class LocationsRepository : ILocationsRepository
    {
        public IEnumerable<Location> GetLocations()
        {
            const string connStr = "server=localhost;user=root;database=theatre;port=3306;password=abc123;";
            var conn = new MySqlConnection(connStr);
            var locations = new List<Location>();
            try
            {
                conn.Open();

                const string sql = "SELECT * FROM theatre.location;";
                var cmd = new MySqlCommand(sql, conn);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var location = new Location
                    {
                        LocationId = Convert.ToInt32(rdr[0]),
                        Title = rdr[1].ToString(),
                        ImageUrl = rdr[2].ToString(),
                        GoogleMap = rdr[3].ToString(),
                        Description = rdr[4].ToString()

                    };
                    locations.Add(location);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return locations;
        }
    }
}