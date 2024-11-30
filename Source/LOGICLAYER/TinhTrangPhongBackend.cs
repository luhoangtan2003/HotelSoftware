using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class TinhTrangPhongBackend
    {
        QLKSEntities Adapter = new();

        public List<TINHTRANGPHONG_TBL> LoadDataTable()
        {
            return Adapter.TINHTRANGPHONG_TBL.ToList();
        }
    }
}