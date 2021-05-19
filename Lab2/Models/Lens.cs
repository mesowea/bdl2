using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Lens
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Display(Name = "Виробник")]
        public string Manufacturer { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Модель")]
        public string Model { get; set; }
        [Range(0, 100)]
        [Required]
        [Display(Name = "Апертура")]
        public int Aperture { get; set; }
        [Range(0,20000)]
        [Required]
        [Display(Name = "Мінімальна фокусна відстань")]
        public int Min_focal_length{ get; set; }
        [Range(0, 20000)]
        [Display(Name = "Максимальна фокусна відстань")]
        public int Max_focal_length { get; set; }
        [Required]
        [Display(Name = "Кріплення")]
        public int Mounting_id { get; set; }
    }
}
