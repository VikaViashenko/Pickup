using Pickup.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.Domain.ViewModels.Phone
{
    public class PhoneViewModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public int BatteryCapacity { get; set; }

        public decimal Price { get; set; }

        public string Features { get; set; }
    }
}
