using Pickup.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Decsription { get; set; }

        public StatusCode StatusCode { get; set; }

        public T Data { get; set; }
    }

    public interface IBaseResponse<T>
    {
        StatusCode StatusCode { get; }
        T Data { get; }
    }
}
