using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class TrangThaiDPBackend
    {
        QLKSEntities Adapter = new();

        public List<TRANGTHAIDP_TBL> LoadDataTable()
        {
            return Adapter.TRANGTHAIDP_TBL.ToList();
        }
    }
}