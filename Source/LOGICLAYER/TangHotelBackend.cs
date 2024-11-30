using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class TangHotelBackend
    {
        public readonly QLKSEntities Adapter = new();

        public List<TangHotelCustom> LoadDataTable()
        {
            List<TANGHOTEL_TBL> TangList;

            List<TangHotelCustom> Result;

            TangList = Adapter.TANGHOTEL_TBL.AsNoTracking().ToList();

            Result = TangList.Select(Tang =>
            {
                Int32 TangThu = Tang.TANGTHU;

                Int32 PhongActive = GetSoLuongPhong(TangThu, "ACTIVE");

                Int32 PhongRevamp = GetSoLuongPhong(TangThu, "REVAMP");

                Int32 PhongUnused = GetSoLuongPhong(TangThu, "UNUSED");

                Int32 TongSoPhong = GetSoLuongPhong(TangThu, String.Empty);

                return new TangHotelCustom
                {
                    TENTANG = Tang.TENTANG,

                    TANGTHU = Tang.TANGTHU,

                    PHONGACTIVE = PhongActive,

                    PHONGREVAMP = PhongRevamp,

                    PHONGUNUSED = PhongUnused,

                    TONGSOPHONG = TongSoPhong,
                };

            }).ToList(); return Result;
        }

        public Boolean Duplicate(Int32 MaSoTang)
        {
            Boolean Has = Adapter.TANGHOTEL_TBL.AsNoTracking().Any(x => x.TANGTHU == MaSoTang);

            return Has;
        }

        public void Add(TANGHOTEL_TBL NewTang)
        {
            Adapter.TANGHOTEL_TBL.Add(NewTang);

            Adapter.SaveChanges();
        }

        public void Edit(TANGHOTEL_TBL NewTang)
        {
            Int32 MaTang = NewTang.TANGTHU;

            TANGHOTEL_TBL Row = Adapter.TANGHOTEL_TBL.FirstOrDefault(x => x.TANGTHU == MaTang);

            Row.TENTANG = NewTang.TENTANG;

            Adapter.SaveChanges();
        }

        public void Remove(Int32 MaSoTangHotel)
        {
            Int32 MaTang = MaSoTangHotel;

            TANGHOTEL_TBL Row = Adapter.TANGHOTEL_TBL.FirstOrDefault(x => x.TANGTHU == MaTang);

            Adapter.TANGHOTEL_TBL.Remove(Row);

            Adapter.SaveChanges();
        }

        public Int32 GetSoLuongPhong(Int32 TangThu, String TinhTrangPhong)
        {
            IQueryable<PHONGNGHI_TBL> Query = Adapter.PHONGNGHI_TBL.AsNoTracking().Where(x => x.TANGTHU == TangThu);

            if (!String.IsNullOrEmpty(TinhTrangPhong))
            {
                Query = Query.Where(x => x.MATINHTRANG == TinhTrangPhong);
            }

            return Query.Count();
        }
    }
}