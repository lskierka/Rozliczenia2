using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozliczenia.Models.Interfaces;

namespace Rozliczenia.Models.Interfaces
{
    public interface IParowanie
    {
        List<ParowanieViewModel> GetParowanie();
    }
}
