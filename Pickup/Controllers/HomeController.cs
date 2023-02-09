using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using Pickup.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pickup.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
