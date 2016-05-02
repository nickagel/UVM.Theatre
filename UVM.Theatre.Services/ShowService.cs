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
            return _showRepository.GetCurrentShows();
        }

    }
}