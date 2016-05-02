using System.Web.Mvc;
using UVM.Theatre.Services;

namespace UVM.Theatre.Controllers
{
    public class TheatreController : Controller
    {
        private readonly IShowService _showService;

        private readonly ILocationsService _locationsService;

        public TheatreController(IShowService showService, ILocationsService locationsService)
        {
            _showService = showService;
            _locationsService = locationsService;
        }
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shows()
        {
            var shows = _showService.GetAllActiveShows();
            return View(shows);
        }

        public ActionResult Location()
        {
            var locations = _locationsService.GetLocations();
            return View(locations);
        }

        public ActionResult Archive()
        {
            var shows = _showService.GetAllActiveShows();
            return View(shows);
        }

        public ActionResult Show()
        {
            var shows = _showService.GetAllActiveShows();
            return View(shows);
        }
    }
}
