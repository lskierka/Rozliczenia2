﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozliczenia.Models.Interfaces
{
    public interface IWplaty
    {
        List<WplatyViewModel> GetWplaty(string userId);
    }
}
