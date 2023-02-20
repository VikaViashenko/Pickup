using Pickup.Domain.Enum;
using System;

namespace Pickup.Domain.Entity
{
    public class Phone
    {
        public int id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Brand { get; set; }

        public string Series { get; set; }

        public string Color { get; set; }

        public int BatteryCapacity { get; set; }

        public decimal Price { get; set; }

        public int Release { get; set; }

        public Features Features { get; set; }

        public byte[]? Avatar { get; set; }
    }
}
