using System.Collections.Generic;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Repositories
{
    public interface IBannerRepository
    {
        IEnumerable<Banner> GetBanners();
    }
}
