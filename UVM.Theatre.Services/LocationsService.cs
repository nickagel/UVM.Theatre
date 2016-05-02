using System.Collections.Generic;
using NUnit.Framework;
using UVM.Theatre.Domain.Models;
using UVM.Theatre.Repositories;

namespace UVM.Theatre.Services
{
    public class LocationsService : ILocationsService
    {
        private readonly ILocationsRepository _locationsRepository;

        public LocationsService(ILocationsRepository locationsRepository)
        {
            _locationsRepository = locationsRepository;
        }

        
        public IEnumerable<Location> GetLocations()
        {
           return  _locationsRepository.GetLocations();
        }
    }
}