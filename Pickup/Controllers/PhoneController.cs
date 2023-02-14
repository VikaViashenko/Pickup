using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pickup.Domain.ViewModels.Phone;
using Pickup.Service.Interfaces;
using System.Threading.Tasks;

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

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data.ToList());
            }
            return RedirectToAction("Error");
        }

        [HttpGet]
        public async Task<IActionResult> GetPhone(int id)
        {
            var response = await _phoneService.GetPhone(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

        /*[Authorize(Roles = "Admin")]*/
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _phoneService.DeletePhone(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetPhones");
            }
            return RedirectToAction("Error");
        }

        [HttpGet]
        /*[Authorize(Roles = "Admin")]*/
        public async Task<ActionResult> Save(int id)
            //передається id, якщо id = 0 то ми будем добавляти новий об'єкт в нашу базу даних. якщо id не буде дорівнювати нулю то ми будем редагувати вже існуючий запис за вказаним id.
        {
            if (id == 0)
            {
                return View();
            }
            var response = await _phoneService.GetPhone(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

        [HttpPost]
        public async Task<IActionResult> Save(PhoneViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.id == 0)
                {
                    await _phoneService.CreatePhone(model);
                }
                else
                {
                    await _phoneService.Edit(model.id, model);
                }
            }
            return RedirectToAction("GetPhones");
        }


    }
}
