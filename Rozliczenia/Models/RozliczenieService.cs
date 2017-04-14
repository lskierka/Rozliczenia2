using System.Collections.Generic;
using System.Linq;
using Rozliczenia.Models.Interfaces;
using Rozliczenia.Models;
using Microsoft.AspNet.Identity;

namespace Rozliczenia.Models
{
    public class RozliczenieService : IRozliczenie
    {

        private readonly EF.IDataModelEF _context;
        public RozliczenieService(EF.IDataModelEF context)
        {
            _context = context;
        }

       

        public List<RozliczenieViewModel> GetRozliczenie(string userId)
        {

          
            var vUser = new UserIdKontraktuViewModel();
            var db2 = _context.CreateNew();

            int? vKontrakt = db2.AspNetUsers.SingleOrDefault(d=> d.Id == userId)?.IdKontraktu;
            using (var db = _context.CreateNew())
            {
                var query = db.vPokazRozliczenieWplat.Where(d => d.IdKontraktu == vKontrakt).ToList()
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
