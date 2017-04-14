using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozliczenia.Models.EF
{
    public class DataModelEF : IDataModelEF
    {
        public ProdukcjaEntities CreateNew()
        {
            return new ProdukcjaEntities();
        }
    }
}
