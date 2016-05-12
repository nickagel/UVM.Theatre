using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Repositories
{
    public class BannerRepository : IBannerRepository
    {
        public IEnumerable<Banner> GetBanners()
        {
            const string connStr = "server=localhost;user=root;database=theatre;port=3306;password=abc123;";
            var conn = new MySqlConnection(connStr);
            var banners = new List<Banner>();
            try
            {
                conn.Open();

                const string sql = "SELECT id, url, urlOrder FROM theatre.banner ORDER BY urlOrder asc;";
                var cmd = new MySqlCommand(sql, conn);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var banner = new Banner
                    {
                        Id = Convert.ToInt32(rdr[0]),
                        Url = rdr[1].ToString(),
                        Order = Convert.ToInt32(rdr[2])
                    };
                    banners.Add(banner);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return banners;
        }
    }
}