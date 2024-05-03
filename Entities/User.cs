﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ad"), StringLength(50), Required]
        public string Name { get; set; }
        [Display(Name = "Soyad"), StringLength(50), Required]
        public string Surname { get; set; }
        [StringLength(50), Required]
        public string Email { get; set; }
        [Display(Name = "Telefon"), StringLength(15)]
        public string? Phone { get; set; }
        [Display(Name = "Şifre"), StringLength(50), Required]
        public string Password { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
    }
}