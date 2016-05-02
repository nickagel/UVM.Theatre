using System.Collections.Generic;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Repositories
{
    public interface ILocationsRepository
    {
        IEnumerable<Location> GetLocations();
    }
}
