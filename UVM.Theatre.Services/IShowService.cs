using System.Collections.Generic;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Services
{
    public interface IShowService
    {
        IEnumerable<Show> GetAllActiveShows();

        IEnumerable<Show> GetAllArchivedShows();
        Show GetShowById(int id);

        Show GetArchivedShowById(int id);
    }
}
