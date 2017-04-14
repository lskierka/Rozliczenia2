using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Rozliczenia.Models
{
    public class WplatyViewModel
    {
        [Required]
        [Display(Name = "Kontrakt")]
        [StringLength(12)]
        public int IdKontraktu { get; set; }

        [Required]
        [Display(Name = "DataWpisu")]
        [StringLength(30)]
        public DateTime  DataWpisu { get; set; }

        [Required]
        [Display(Name = "Kwota")]
        [StringLength(6)]
        public decimal Kwota { get; set; }

        [Required]
        [Display(Name = "KwotaWolna")]
        [StringLength(6)]
        public decimal KwotaWolna { get; set; }

        [Required]
        [Display(Name = "Id Wplaty")]
        [StringLength(12)]
        public int IdWplaty { get; set; }

    }
}