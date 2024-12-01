using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class TrangThaiDVBackend
    {
        QLKSEntities Adapter = new();

        public List<TRANGTHAIDV_TBL> LoadDataTable()
        {
            return Adapter.TRANGTHAIDV_TBL.ToList();
        }
    }
}