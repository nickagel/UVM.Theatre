using System.Collections.Generic;
using UVM.Theatre.Domain.Models;
using UVM.Theatre.Repositories;

namespace UVM.Theatre.Services
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository _showRepository;
        public ShowService(IShowRepository showRepository)
        {
            _showRepository = showRepository;
        }

        public IEnumerable<Show> GetAllActiveShows()
        {
            return _showRepository.GetCurrentShows(0);
        }

        public Show GetShowById(int id)
        {
            return _showRepository.GetShowById(id, 0);
        }

        public IEnumerable<Show> GetAllArchivedShows()
        {
            return _showRepository.GetCurrentShows(1);
        }

        public Show GetArchivedShowById(int id)
        {
            return _showRepository.GetShowById(id, 1);
        }

    }
}