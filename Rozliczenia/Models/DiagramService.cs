using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozliczenia.Models.Interfaces;

namespace Rozliczenia.Models
{
    public class RozliczenieService : IRozliczenie
    {

        private readonly EF.IDataModelEF _context;
        public RozliczenieService(EF.IDataModelEF context)
        {
            _context = context;
        }


        public List<RozliczenieViewModel> GetRozliczenie()
        {
            using (var db = _context.CreateNew())
            {
                var query = db.vPokazRozliczenieWplat.ToList()
                    .Select(X => new RozliczenieViewModel
                    {
                        IdKontraktu = X.IdKontraktu,
                        DataWpisu = X.DataWpisu,
                        KwotaWplatyBankowej = X.KwotaWplatyBankowej,
                        KwotaPartiiWplaty = X.KwotaPartiiWplaty,
                        Usluga = X.Usluga,
                        KwotaNaleznosci = X.KwotaNaleznosci,
                        IdWplaty = X.IdWplaty
                    }
                    ).ToList();
                return query;
            }
        }
      
    }
}
