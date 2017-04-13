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

       

        public List<ParowanieViewModel> GetParowanie()
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
                var query = db.vPokazParowanieNaleznosci.Where(d => d.IdKontraktu == 8).ToArray()
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
