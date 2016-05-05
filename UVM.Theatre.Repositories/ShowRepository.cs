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
            const string connStr = "server=localhost;user=root;database=theatre;port=3306;password=abc123;";
            var conn = new MySqlConnection(connStr);
            var shows = new List<Show>();
            try
            {
                conn.Open();

                const string sql = "SELECT * FROM theatre.show where archive = 0;";
                var cmd = new MySqlCommand(sql, conn);
                var rdr = cmd.ExecuteReader();

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

        public Show GetShowById(int id)
        {
            const string connStr = "server=localhost;user=root;database=theatre;port=3306;password=abc123;";
            var conn = new MySqlConnection(connStr);
            Show show = null;
            try
            {
                conn.Open();

                var sql = "SELECT * FROM theatre.show WHERE archive = 0 AND showId =" + id + ";";
                var cmd = new MySqlCommand(sql, conn);
                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    show = new Show
                    {
                        ShowId = Convert.ToInt32(rdr[0]),
                        Title = rdr[1].ToString(),
                        SubTitle = rdr[2].ToString(),
                        Director = rdr[3].ToString(),
                        ShowDates = rdr[4].ToString(),
                        Description = rdr[5].ToString(),
                        Image = rdr[6].ToString()

                    };
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return show;
        }
    }
}