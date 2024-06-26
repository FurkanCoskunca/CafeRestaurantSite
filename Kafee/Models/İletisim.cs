﻿using System.ComponentModel.DataAnnotations;

namespace Kafee.Models
{
    public class İletisim
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }
}
