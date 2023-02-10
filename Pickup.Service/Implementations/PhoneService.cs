using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using Pickup.Domain.Enum;
using Pickup.Domain.Response;
using Pickup.Domain.ViewModels.Phone;
using Pickup.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.Service.Implementations
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneService(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public async Task<IBaseRepository<Phone>> GetPhone(int id) //пошук об'єкта по id
        {
            var baseResponse = new BaseResponse<Phone>();
            try
            {
                var phone = await _phoneRepository.Get(id);
                if (phone == null)
                {
                    baseResponse.Decsription = "User not found";
                    baseResponse.StatusCode = StatusCode.UserNotFound;
                    return (IBaseRepository<Phone>)baseResponse;
                }
                baseResponse.Data = phone;
                return (IBaseRepository<Phone>)baseResponse;
            }
            catch (Exception ex)
            {
                return null;
                /*return new BaseResponse<Phone>()
                {
                    Decsription = $"[GetPhone] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };*/
            }
        }

        public async Task<IBaseResponse<IEnumerable<Phone>>> GetPhones()
        {
            var baseResponse = new BaseResponse<IEnumerable<Phone>>();
            try
            {
                var phones = await _phoneRepository.Select();
                if (phones.Count == 0)
                {
                    baseResponse.Decsription = "Знайдено нуль елементів";
                    baseResponse.StatusCode = StatusCode.OK;
                    return baseResponse;
                }
                baseResponse.Data = phones;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Phone>>()
                {
                    Decsription = $"[GetPhones] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }




        public async Task<IBaseRepository<Phone>> GetPhoneByName(string name) //пошук об'єкта по name
        {
            var baseResponse = new BaseResponse<Phone>();
            try
            {
                var phone = await _phoneRepository.GetByName(name);
                if (phone == null)
                {
                    baseResponse.Decsription = "User not found";
                    baseResponse.StatusCode = StatusCode.UserNotFound;
                    return (IBaseRepository<Phone>)baseResponse;
                }
                baseResponse.Data = phone;
                return (IBaseRepository<Phone>)baseResponse;
            }
            catch (Exception ex)
            {
                return null;
                /*return new BaseResponse<Phone>()
                {
                    Decsription = $"[GetPhoneByName] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };*/
            }
        }

        public async Task<IBaseResponse<bool>> DeletePhone(int id)
        {
            var baseResponse = new BaseResponse<bool>()
            {
                Data = true
            };
            try
            {
                var phone = await _phoneRepository.Get(id);
                if (phone == null)
                {
                    baseResponse.Decsription = "User not found";
                    baseResponse.StatusCode = StatusCode.UserNotFound;
                    baseResponse.Data = false;

                    return baseResponse;
                }
                await _phoneRepository.Delete(phone);

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Decsription = $"[DeletePhone] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> CreatePhone(PhoneViewModel phoneViewModel)
        {
            var baseResponse = new BaseResponse<PhoneViewModel>();
            try
            {
                var phone = new Phone()
                {
                    Name = phoneViewModel.Name,
                    Brand = phoneViewModel.Brand,
                    Color = phoneViewModel.Color,
                    BatteryCapacity = phoneViewModel.BatteryCapacity,
                    Price = phoneViewModel.Price,
                    Features = (Features)Convert.ToInt32(phoneViewModel.Features) 
                };
                await _phoneRepository.Create(phone);
            }
            catch (Exception ex)
            {
                return null;/*
                return new BaseResponse<PhoneViewModel>()
                {
                    Decsription = $"[CreatePhone]: {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };*/
            }
            return (IBaseResponse<bool>)baseResponse;
        }

        public async Task<IBaseResponse<Phone>> Edit(int id, PhoneViewModel model)
        {
            var baseResponse = new BaseResponse<Phone>();
            try
            {
                var phone = await _phoneRepository.Get(id);
                if (phone == null)
                {
                    baseResponse.StatusCode = StatusCode.PhoneNotFound;
                    baseResponse.Decsription = "Phone not found";
                    return baseResponse;
                }
                phone.Name = model.Name;
                phone.Brand = model.Brand;
                phone.Color = model.Color;
                phone.BatteryCapacity = model.BatteryCapacity;
                phone.Price = model.Price;

                await _phoneRepository.Update(phone);

                return baseResponse;
                //Features!!!
            }
            catch (Exception ex)
            {
                return new BaseResponse<Phone>()
                {
                    Decsription = $"[Edit]: {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }





        Task<IBaseResponse<Phone>> IPhoneService.GetPhone(int id)
        {
            throw new NotImplementedException();
        }

        Task<IBaseResponse<PhoneViewModel>> IPhoneService.CreatePhone(PhoneViewModel phoneViewModel)
        {
            throw new NotImplementedException();
        }

        Task<IBaseResponse<Phone>> IPhoneService.GetPhoneByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
