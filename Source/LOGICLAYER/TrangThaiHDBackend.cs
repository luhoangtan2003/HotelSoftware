using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class TrangThaiHDBackend
    {
        QLKSEntities Adapter = new();

        public List<TRANGTHAIHD_TBL> LoadDataTable()
        {
            return Adapter.TRANGTHAIHD_TBL.ToList();
        }
    }
}