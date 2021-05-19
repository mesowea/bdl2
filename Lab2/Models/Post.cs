using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Акаунт")]
        public int Account_id { get; set; }
        [Required]
        [Display(Name = "Камера")]
        public int Camera_id { get; set; }
        [Required]
        [Display(Name = "Об'єктив")]
        public int Lens_id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата публікації")]
        public DateTime Publish_date { get; set; }
        [Required]
        [Display(Name = "Назва")]
        public string Title { get; set; }
        [Range(0, 100)]
        [Required]
        [Display(Name = "Важливість")]
        public int Pulse { get; set; }
    }
}
