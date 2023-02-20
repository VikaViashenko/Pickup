using System.ComponentModel.DataAnnotations;

namespace Pickup.Domain.Enum
{
    public enum Features
    {
        [Display(Name = "Смартфони")]
        Smartphones = 0,
        [Display(Name = "Флагмани")]
        Flagship = 1,
        [Display(Name = "Ігрові смартфони")]
        GamingSmartphones = 2,
        [Display(Name = "Камерофони")]
        CameraPhones = 3,
        [Display(Name = "Хороша автономність")]
        LongBatteryLife = 4,
        [Display(Name = "Ударостійкі")]
        Shockproof = 5,
        [Display(Name = "Водонепроникні")]
        Waterproof = 6,
        [Display(Name = "Кнопочні телефони")]
        FeaturePhones = 7
    }
}
