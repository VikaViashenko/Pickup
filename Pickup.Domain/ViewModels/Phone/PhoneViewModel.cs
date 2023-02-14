using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace Pickup.Domain.ViewModels.Phone
{
    public class PhoneViewModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public int BatteryCapacity { get; set; }

        public decimal Price { get; set; }

        public int Release { get; set; }

        public string Features { get; set; }

        public IFormFile Avatar { get; set; }
    }
}
