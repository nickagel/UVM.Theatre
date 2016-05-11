using System.Collections.Generic;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Repositories
{
    public interface IShowRepository
    {
        IEnumerable<Show> GetCurrentShows(int archive);

        Show GetShowById(int id, int archive);
    }
}
