using System.Collections.Generic;
using UVM.Theatre.Domain.Models;
using UVM.Theatre.Repositories;

namespace UVM.Theatre.Services
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepository _bannerRepository;

        public BannerService(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public IEnumerable<Banner> GetBanners()
        {
            return _bannerRepository.GetBanners();
        }
    }
}