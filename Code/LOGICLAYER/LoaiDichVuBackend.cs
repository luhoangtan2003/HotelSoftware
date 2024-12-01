using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class LoaiDichVuBackend
    {
        readonly QLKSEntities Adapter = new QLKSEntities();

        public List<LOAIDV_TBL> LoadDataTable()

            => Adapter.LOAIDV_TBL.AsNoTracking().ToList();

        public void Add(LOAIDV_TBL NewLoai)
        {
            Adapter.LOAIDV_TBL.Add(NewLoai);

            Adapter.SaveChanges();
        }

        public void Edit(LOAIDV_TBL NewLoai)
        {
            String MaLoaiDV = NewLoai.MALOAIDV;

            LOAIDV_TBL Row = Adapter.LOAIDV_TBL.FirstOrDefault(x => x.MALOAIDV == MaLoaiDV);

            Row.TENLOAIDV = NewLoai.TENLOAIDV;

            Row.MOTA = NewLoai.MOTA;

            Adapter.SaveChanges();
        }

        public void Remove(String MaLoaiDV)
        {
            LOAIDV_TBL Row = Adapter.LOAIDV_TBL.FirstOrDefault(x => x.MALOAIDV == MaLoaiDV);

            Adapter.LOAIDV_TBL.Remove(Row);

            Adapter.SaveChanges();
        }

        public Boolean Duplicate(String MaLoaiDV)
        {
            return Adapter.LOAIDV_TBL.AsNoTracking().Any(x => x.MALOAIDV == MaLoaiDV);
        }

        public Boolean Referenced(String MaLoaiDV)
        {
            return Adapter.DICHVU_TBL.AsNoTracking().Any(x => x.MALOAIDV == MaLoaiDV);
        }
    }
}