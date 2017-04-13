using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Rozliczenia.Models.Interfaces;

namespace Rozliczenia.Models
{
    public class WplatyService : IWplaty
    {

        private readonly EF.IDataModelEF _context;
        public WplatyService(EF.IDataModelEF context)
        {
            _context = context;
        }
         
    

    public List<WplatyViewModel> GetWplaty()
        {
            var vUser = new RegisterViewModel();

            int idKontraktu = 8;
            using (var db = _context.CreateNew())
            {
                var query = db.vPokazWszystkieWplaty.Where(d => d.IdKontraktu == idKontraktu).ToList()
                    .Select(X => new WplatyViewModel
                    {
                        IdKontraktu = X.IdKontraktu,
                        DataWpisu = X.DataWpisu,
                        Kwota = X.Kwota,
                        KwotaWolna = X.KwotaWolna,
                        IdWplaty = X.IdWplaty
                    }
                    ).ToList();
                return query;
            }
        }
  
    }
}
