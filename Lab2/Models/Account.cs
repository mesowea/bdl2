using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Account
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name ="Юзернейм")]
        public string Username { get; set; }
        [MaxLength(50)]
        [Display(Name = "Ім'я")]
        public string Fullname { get; set; }
        [MaxLength(50)]
        [Display(Name = "Країна")]
        public string Country { get; set; }
    }
}
