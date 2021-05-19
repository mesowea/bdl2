using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Mounting
    {
        [Display(Name = "Номер")]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name = "Назва")]
        public string Name { get; set; }
    }
}
