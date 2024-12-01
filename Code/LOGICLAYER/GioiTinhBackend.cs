using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class GioiTinhBackend
    {
        QLKSEntities Adapter = new QLKSEntities();

        public List<GIOITINH_TBL> LoadDataTable()
        {
            return Adapter.GIOITINH_TBL.ToList();
        }
    }
}