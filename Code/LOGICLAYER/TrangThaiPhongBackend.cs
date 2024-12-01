using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class TrangThaiPhongBackend
    {
        QLKSEntities Adapter = new();

        public List<TRANGTHAIPHONG_TBL> LoadDataTable()
        {
            return Adapter.TRANGTHAIPHONG_TBL.ToList();
        }
    }
}