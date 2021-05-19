using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Camera
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Display(Name = "Виробник")]
        public string Manufacturer { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Модель")]
        public string Model { get; set; }
        [Range(0, 500000)]
        [Required]
        [Display(Name = "Мінімальне значення ISO")]
        public int Min_ISO { get; set; }
        [Range(0, 500000)]
        [Required]
        [Display(Name = "Максимальне значення ISO")]
        public int Max_ISO { get; set; }
        [Required]
        [Display(Name = "Кріплення")]
        public int Mounting_id { get; set; }
    }
}
