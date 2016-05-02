using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Repositories
{
    public class ShowRepository : IShowRepository
    {
        public IEnumerable<Show> GetCurrentShows()
        {
            var connStr = "server=localhost;user=root;database=theatre;port=3306;password=abc123;";
            var conn = new MySqlConnection(connStr);
            var shows = new List<Show>();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM theatre.show where archive = 0;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var show = new Show
                    {
                        ShowId = Convert.ToInt32(rdr[0]),
                        Title = rdr[1].ToString(),
                        SubTitle = rdr[2].ToString(),
                        Director = rdr[3].ToString(),
                        ShowDates = rdr[4].ToString(),
                        Description = rdr[5].ToString(),
                        Image = rdr[6].ToString()

                    };
                    shows.Add(show);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return shows;
        }
    }
}