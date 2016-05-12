using System.Collections.Generic;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Services
{
    public interface IBannerService
    {
        IEnumerable<Banner> GetBanners();
    }
}
