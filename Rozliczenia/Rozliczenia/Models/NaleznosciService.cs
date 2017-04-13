using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozliczenia.Models.Interfaces;


namespace Rozliczenia.Models
{
    public class NaleznosciService : INaleznosci
    {

        private readonly EF.IDataModelEF _context;
        public NaleznosciService(EF.IDataModelEF context)
        {
            _context = context;
        }


        public List<NaleznosciViewModel> GetNaleznosci()
        {
            var vUser = new UserIdKontraktuViewModel();
            using (var db = _context.CreateNew())
            {
                var query = db.vPokazWszystkieNaleznosci.Where(d => d.IdKontraktu == vUser.IdKontraktu).ToList()
                    .Select(X => new NaleznosciViewModel
                    {
                        IdKontraktu = vUser.IdKontraktu,
                        Usluga = X.Usluga,
                        OkresDataOd = X.OkresDataOd,
                        OkresDataDo = X.OkresDataDo,
                        Kwota = X.Kwota,
                        KwotaRozliczona = X.KwotaRozliczona,
                        DoZaplaty = X.DoZaplaty,
                        IdPartiiNaleznosci = X.idPartiiNaleznosci
                        ,
                    }
                    ).ToList();
                return query;
            }
        }

    }
}
