using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TV_Dashboard.DbContext;
using TV_Dashboard.Models;

namespace TV_Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public DashboardController(ILogger<DashboardController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            this._applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View(_applicationDbContext.MainLogsTable.OrderByDescending(c => c.LogId).Take(18));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}