using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDavet.Models
{
    public class Cevap
    {
        [Required(ErrorMessage="Lütfen Ad Alanını boş bırakmayınız!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen SoyAd Alanını boş bırakmayınız!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen Email Alanını boş bırakmayınız!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon Alanını boş bırakmayınız!")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Lütfen bir seçim yapınız!")]
        public bool? DuguneGelecekMi { get; set; }
    }
}
