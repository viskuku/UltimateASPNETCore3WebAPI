﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAisWebRepository
    {
        Task PegarNotamPorDataAsync(DateTime dataBusca);
    }
}
