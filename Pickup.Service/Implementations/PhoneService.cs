using Microsoft.EntityFrameworkCore;
using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using Pickup.Domain.Enum;
using Pickup.Domain.Response;
using Pickup.Domain.ViewModels.Phone;
using Pickup.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.Service.Implementations
{
    public class PhoneService : IPhoneService
    {
        private readonly IBaseRepository<Phone> _phoneRepository;

        public PhoneService(IBaseRepository<Phone> phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public async Task<IBaseResponse<PhoneViewModel>> GetPhone(int id) //пошук об'єкта по id
        {
            try
            {
                var phone = await _phoneRepository.GetAll().FirstOrDefaultAsync(x => x.id == id);
                if (phone == null)
                {
                    return new BaseResponse<PhoneViewModel>()
                    {
                        Description = "User not found",
                        StatusCode = StatusCode.UserNotFound
                    };
                }

                var data = new PhoneViewModel()
                {
                    Name = phone.Name,
                    Brand = phone.Brand,
                    Color = phone.Color,
                    BatteryCapacity = phone.BatteryCapacity,
                    Price = phone.Price,
                    Release = phone.Release,
                    Description = phone.Description,
                    Features = phone.Features.ToString(),
                    Image = phone.Avatar
                };
                return new BaseResponse<PhoneViewModel>()
                {
                    StatusCode = StatusCode.OK,
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PhoneViewModel>()
                {
                    Description = $"[GetPhone] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Phone>>> GetPhones()
        {
            try
            {
                var phones = _phoneRepository.GetAll();
                if (!phones.Any())
                {
                    return new BaseResponse<IEnumerable<Phone>>()
                    {
                        Description = "Знайдено нуль елементів",
                        StatusCode = StatusCode.OK
                    };
                }
                return new BaseResponse<IEnumerable<Phone>>()
                {
                    StatusCode = StatusCode.OK,
                    Data = phones
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Phone>>()
                {
                    Description = $"[GetPhones] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }




        public async Task<IBaseResponse<Phone>> GetPhoneByName(string name) //пошук об'єкта по name
        {
            try
            {
                var phone = await _phoneRepository.GetAll().FirstOrDefaultAsync(x => x.Name == name);
                if (phone == null)
                {
                    return new BaseResponse<Phone>()
                    {
                        Description = "User not found",
                        StatusCode = StatusCode.UserNotFound
                    };
                }
                return new BaseResponse<Phone>()
                {
                    Data = phone,
                    StatusCode = StatusCode.OK,
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Phone>()
                {
                    Description = $"[GetPhoneByName] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeletePhone(int id)
        {
            try
            {
                var phone = await _phoneRepository.GetAll().FirstOrDefaultAsync(x => x.id == id);
                if (phone == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "User not found",
                        StatusCode = StatusCode.UserNotFound,
                        Data = false
                    };
                }
                await _phoneRepository.Delete(phone);

                return new BaseResponse<bool>()
                {
                    Data = true,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeletePhone] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Phone>> CreatePhone(PhoneViewModel model, byte[] imageData)
        {
            try
            {
                var phone = new Phone()
                {
                    Name = model.Name,
                    Brand = model.Brand,
                    Color = model.Color,
                    BatteryCapacity = model.BatteryCapacity,
                    Price = model.Price,
                    Release = model.Release,
                    Description = model.Description,
                    Features = (Features)Convert.ToInt32(model.Features),
                    Avatar = imageData
                };
                await _phoneRepository.Create(phone);

                return new BaseResponse<Phone>()
                {
                    StatusCode = StatusCode.OK,
                    Data = phone
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Phone>()
                {
                    Description = $"[CreatePhone]: {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Phone>> Edit(int id, PhoneViewModel model)
        {
            try
            {
                var phone = await _phoneRepository.GetAll().FirstOrDefaultAsync(x => x.id == id);
                if (phone == null)
                {
                    return new BaseResponse<Phone>()
                    {
                        Description = "Phone not found",
                        StatusCode = StatusCode.PhoneNotFound
                    };
                }
                phone.Name = model.Name;
                phone.Brand = model.Brand;
                phone.Color = model.Color;
                phone.BatteryCapacity = model.BatteryCapacity;
                phone.Price = model.Price;
                phone.Release = model.Release;
                phone.Description = model.Description;

                await _phoneRepository.Update(phone);
                return new BaseResponse<Phone>()
                {
                    Data = phone,
                    StatusCode = StatusCode.OK,
                };
                //Features!!!
            }
            catch (Exception ex)
            {
                return new BaseResponse<Phone>()
                {
                    Description = $"[Edit]: {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
