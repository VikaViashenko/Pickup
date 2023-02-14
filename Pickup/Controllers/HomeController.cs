using Microsoft.AspNetCore.Mvc;
using Pickup.DAL.Interfaces;
using System.Threading.Tasks;

namespace Pickup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
