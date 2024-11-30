using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class QuocTichBackend
    {
        QLKSEntities Adapter = new QLKSEntities();

        public List<QUOCTICH_TBL> LoadDataTable()
        {
            return Adapter.QUOCTICH_TBL.ToList();
        }
    }
}