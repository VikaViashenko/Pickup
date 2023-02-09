using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using Pickup.Domain.Enum;
using Pickup.Domain.Response;
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

        public async Task<IBaseResponse<IEnumerable<Phone>>> GetPhones()
        {
            var baseResponse = new BaseResponse<IEnumerable<Phone>>();
            try
            {
                var phones = await _phoneRepository.Select();
                if (phones.Count == 0)
                {
                    baseResponse.Decsription = "Знайдено нуль елементів";
                    baseResponse.StatusCode = Domain.Enum.StatusCode.OK;
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
                    Decsription = $"[GetPhones] : {ex.Message}"
                };
            }
        }
    }
}
