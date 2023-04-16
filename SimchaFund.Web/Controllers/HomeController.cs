using Microsoft.AspNetCore.Mvc;
using SimchaFund.Web.Models;
using System.Diagnostics;

namespace SimchaFund.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var mgr = new DatabaseManager();
            var vm = new SimchasViewModel();
            vm.Simchas = mgr.AllSimchas();
            return View(vm);
        }
        public IActionResult NewSimcha(string name, DateTime date)
        {
            var mgr = new DatabaseManager();
            mgr.NewSimcha(name, date);
            return Redirect("/home/index");
        }
        public IActionResult Contributors()
        {
            var mgr = new DatabaseManager();
            var vm = new ContributorsViewModel();
            vm.Contributors = mgr.AllContributors();
            return View(vm);
        }
    }
}