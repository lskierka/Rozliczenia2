using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Rozliczenia.Models
{
    public class RozliczenieViewModel
    {
        [Required]
        [Display(Name = "Kontrakt")]
        [StringLength(12)]
        public int IdKontraktu { get; set; }

        [Required]
        [Display(Name = "DataWpisu")]
        [StringLength(30)]
        public DateTime DataWpisu { get; set; }

        [Required]
        [Display(Name = "Kwota wpłaty")]
        [StringLength(6)]
        public decimal KwotaWplatyBankowej { get; set; }

        [Required]
        [Display(Name = "Kwota Partii")]
        [StringLength(6)]
        public decimal KwotaPartiiWplaty { get; set; }

        [Required]
        [Display(Name = "Usługa")]
        [StringLength(200)]
        public String Usluga { get; set; }

        [Required]
        [Display(Name = "Kwota Należności")]
        [StringLength(6)]
        public decimal KwotaNaleznosci { get; set; }

        [Required]
        [Display(Name = "Id Wplaty")]
        [StringLength(12)]
        public int IdWplaty { get; set; }
    }
}
