﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.Domain.Enum
{
    public enum StatusCode
    {
        UserNotFound = 0,
        PhoneNotFound = 10,
        OK = 200,
        InternalServerError = 500
    }
}
