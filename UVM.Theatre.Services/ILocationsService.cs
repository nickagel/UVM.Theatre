using System.Collections.Generic;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Services
{
    public interface ILocationsService
    {
        IEnumerable<Location> GetLocations();
    }
}
