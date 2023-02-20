using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System;

namespace Pickup.Domain.ViewModels.Phone
{
    public class PhoneViewModel
    {
        public int id { get; set; }

        [Display(Name = "Назва телефону")]
        [Required(ErrorMessage = "Вкажіть ім'я")]
        [MinLength(2, ErrorMessage = "Мінімальна довжина повинна бути більше двох символів")]
        public string Name { get; set; }

        [Display(Name = "Бренд")]
        [Required(ErrorMessage = "Вкажіть бренд")]
        public string Brand { get; set; }

        [Display(Name = "Колір")]
        [Required(ErrorMessage = "Вкажіть колір")]
        public string Color { get; set; }

        [Display(Name = "Опис")]
        public string Description { get; set; }

        [Display(Name = "Ємкість батареї")]
        [Required(ErrorMessage = "Вкажіть ємкість батареї")]
        [Range(0, 600, ErrorMessage = "Ємкість повинна бути в діапазоні від 1000 до 10000")]
        public int BatteryCapacity { get; set; }

        [Display(Name = "Ціна")]
        [Required(ErrorMessage = "Вкажіть ціну")]
        public decimal Price { get; set; }

        [Display(Name = "Реліз")]
        public int Release { get; set; }

        [Display(Name = "Особливість телефону")]
        public string Features { get; set; }

        public IFormFile Avatar { get; set; }

        public byte[]? Image { get; set; }
    }
}
