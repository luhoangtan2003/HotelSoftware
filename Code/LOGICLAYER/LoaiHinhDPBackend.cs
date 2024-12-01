using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class LoaiHinhDPBackend
    {
        QLKSEntities Adapter = new QLKSEntities();

        public List<LOAIHINHDP_TBL> LoadDataTable()
        {
            return Adapter.LOAIHINHDP_TBL.ToList();
        }
    }
}