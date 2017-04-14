using System.Collections.Generic;
using System.Linq;
using Rozliczenia.Models.Interfaces;
using Rozliczenia.Models;


namespace Rozliczenia.Models
{
    public class ParowanieService : IParowanie
    {

        private readonly EF.IDataModelEF _context;
        public ParowanieService(EF.IDataModelEF context)
        {
            _context = context;
        }

       

        public List<ParowanieViewModel> GetParowanie(string userId)
        {
            var vUser = new UserIdKontraktuViewModel();
            var db2 = _context.CreateNew();

            int? vKontrakt = db2.AspNetUsers.SingleOrDefault(d => d.Id == userId)?.IdKontraktu;

            using (var db = _context.CreateNew())
            {
                var query = db.vPokazParowanieNaleznosci.Where(d => d.IdKontraktu == vKontrakt).ToArray()
                    .Select(X => new ParowanieViewModel
                    {
                       // IdKontraktu = X.IdKontraktu,
                        KwotaWplatyBankowej = X.KwotaWplatyBankowej,
                        KwotaPartiiWplaty = X.KwotaPartiiWplaty,
                        Naleznosc = X.Naleznosc                    
                    }
                    ).ToList(); 
                return query;
            }
        }

    }
}
