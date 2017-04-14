using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Rozliczenia.Models
{
    public class NaleznosciViewModel
    {
        [Required]
        [Display(Name = "Kontrakt")]
        [StringLength(12)]
        public int IdKontraktu { get; set; }

        [Required]
        [Display(Name = "Usługa")]
        [StringLength(30)]
        public String Usluga { get; set; }

        [Required]
        [Display(Name = "Data Od")]
        [StringLength(30)]
        public DateTime OkresDataOd { get; set; }


        [Required]
        [Display(Name = "Data Do")]
        [StringLength(30)]
        public DateTime OkresDataDo { get; set; }

        [Required]
        [Display(Name = "Kwota")]
        [StringLength(6)]
        public decimal Kwota { get; set; }

        [Required]
        [Display(Name = "KwotaRozliczona")]
        [StringLength(6)]
        public decimal KwotaRozliczona { get; set; }

        [Required]
        [Display(Name = "Do zapłaty")]
        [StringLength(6)]
        public decimal DoZaplaty { get; set; }

        [Required]
        [Display(Name = "Id Naleznosci")]
        [StringLength(12)]
        public int IdPartiiNaleznosci { get; set; }

    }
}