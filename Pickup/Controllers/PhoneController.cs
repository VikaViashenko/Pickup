using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using Pickup.Domain.Enum;
using Pickup.Service.Interfaces;
using System.Drawing;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.Internal.AsyncLock;

namespace Pickup.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneService _phoneService;
        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPhones()
        {
            var response = await _phoneService.GetPhones();
            return View(response.Data);
        }
    }
}
