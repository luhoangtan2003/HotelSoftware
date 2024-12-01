using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class PaymentTimeBackend
    {
        QLKSEntities Adapter = new();

        public List<PAYMENTTIME_TBL> LoadDataTable()
        {
            return Adapter.PAYMENTTIME_TBL.ToList();
        }
    }
}