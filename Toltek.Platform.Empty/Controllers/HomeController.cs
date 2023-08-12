using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Toltek.Services;
using Toltek.Services.Dashboard;
using Toltek.Services.Search;

namespace Toltek.Platform.Empty.Controllers
{
    [Authorize(Roles = "Admin,Reseller,Manager")]
    public class HomeController : HomeControllerBase<HomeController>
    {
        public HomeController(WebServices<HomeController> services, IDashboardService dashboard, ISearchService search) : base(services, dashboard, search)
        {

        }
        public IActionResult Index()
        {
            this.Logger.LogDebug("Empty.home.index");
            //return RedirectToAction("Browse", "Files");
            return View();
        }
    }
}
