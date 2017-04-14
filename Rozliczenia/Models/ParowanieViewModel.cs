using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Rozliczenia.Models
{
    public class ParowanieViewModel
    {
        [Required]
        [Display(Name = "Kontrakt")]
        [StringLength(12)]
        public int IdKontraktu { get; set; }

        [Required]
        [Display(Name = "Wplata bankowa")]
        [StringLength(250)]
        public String KwotaWplatyBankowej { get; set; }

        [Required]
        [Display(Name = "Kwota partii wpłaty")]
        [StringLength(6)]
        public decimal KwotaPartiiWplaty { get; set; }

        [Required]
        [Display(Name = "Należność")]
        [StringLength(250)]
        public String Naleznosc { get; set; }


        [Required]
        [Display(Name = "Id Wplaty")]
        [StringLength(12)]
        public int IdWplaty { get; set; }
    }
}
