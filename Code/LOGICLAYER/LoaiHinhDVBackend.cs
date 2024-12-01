using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class LoaiHinhDVBackend
    {
        QLKSEntities Adapter = new QLKSEntities();

        public List<LOAIHINHDV_TBL> LoadDataTable()
        {
            return Adapter.LOAIHINHDV_TBL.ToList();
        }
    }
}