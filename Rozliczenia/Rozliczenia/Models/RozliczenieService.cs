using System.Collections.Generic;
using System.Linq;
using Rozliczenia.Models.Interfaces;
using Rozliczenia.Models;

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

      /*      var user = _context.Users.Where(u => u.ID == id)
             .Select(u => new UserViewModel
             {
                 ID = u.ID,
                 FirstName = u.FirstName,
                 LastName = u.LastName,
                 FotherName = u.FotherName
             }).Single();
             */
            var vUser = new UserIdKontraktuViewModel();
            int vKontrakt = vUser.IdKontraktu;
           using (var db = _context.CreateNew())
            {
                var query = db.vPokazRozliczenieWplat.Where(d => d.IdKontraktu == 8).ToList()
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
