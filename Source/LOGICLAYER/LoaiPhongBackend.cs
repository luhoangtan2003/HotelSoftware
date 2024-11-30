using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class LoaiPhongBackend
    {
        QLKSEntities Adapter = new QLKSEntities();

        public void Add(LOAIPHONG_TBL NewLoai)
        {
            Adapter.LOAIPHONG_TBL.Add(NewLoai);

            Adapter.SaveChanges();
        }

        public void Edit(LOAIPHONG_TBL NewLoai)
        {
            String MaLoaiPhong = NewLoai.MALOAIPHONG;

            LOAIPHONG_TBL Row = Adapter.LOAIPHONG_TBL.FirstOrDefault(x => x.MALOAIPHONG == MaLoaiPhong);

            Row.TENLOAIPHONG = NewLoai.TENLOAIPHONG;

            Row.SUCCHUA = NewLoai.SUCCHUA;

            Row.SOGIUONG = NewLoai.SOGIUONG;

            Row.MOTA = NewLoai.MOTA;

            Row.TIENTHEOH = NewLoai.TIENTHEOH;

            Row.TIENTHEOD = NewLoai.TIENTHEOD;

            Adapter.SaveChanges();
        }

        public void Remove(String MaLoaiPhong)
        {
            LOAIPHONG_TBL Row = Adapter.LOAIPHONG_TBL.FirstOrDefault(x => x.MALOAIPHONG == MaLoaiPhong);

            Adapter.LOAIPHONG_TBL.Remove(Row);

            Adapter.SaveChanges();
        }

        public Boolean Duplicate(String MaLoaiPhong)
        {
            return Adapter.LOAIPHONG_TBL.AsNoTracking().Any(x => x.MALOAIPHONG == MaLoaiPhong);
        }

        public Boolean Referenced(String MaLoaiPhong)
        {
            return Adapter.PHONGNGHI_TBL.AsNoTracking().Any(x => x.MALOAIPHONG == MaLoaiPhong);
        }

        public List<LOAIPHONG_TBL> LoadDataTable()

                                              => Adapter.LOAIPHONG_TBL.AsNoTracking().ToList();
    }
}