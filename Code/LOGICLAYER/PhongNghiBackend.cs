using DATALAYER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LOGICLAYER
{
    public class PhongNghiBackend
    {
        readonly QLKSEntities Adapter = new QLKSEntities();

        public IQueryable<PhongNghiCustom> LoadDataTable()

        => from PhongNghi in Adapter.PHONGNGHI_TBL.AsNoTracking()

           join TangHotel in Adapter.TANGHOTEL_TBL.AsNoTracking()

           on PhongNghi.TANGTHU equals TangHotel.TANGTHU

           join LoaiPhong in Adapter.LOAIPHONG_TBL.AsNoTracking()

           on PhongNghi.MALOAIPHONG equals LoaiPhong.MALOAIPHONG

           join TrangThai in Adapter.TRANGTHAIPHONG_TBL.AsNoTracking()

           on PhongNghi.MATRANGTHAI equals TrangThai.MATRANGTHAI

           join TinhTrang in Adapter.TINHTRANGPHONG_TBL.AsNoTracking()

           on PhongNghi.MATINHTRANG equals TinhTrang.MATINHTRANG

           select new PhongNghiCustom { MAPHONG = PhongNghi.MAPHONG, TENPHONG = PhongNghi.TENPHONG, TANGTHU = PhongNghi.TANGTHU, TENTANG = TangHotel.TENTANG, TIENTHEOD = LoaiPhong.TIENTHEOD, TIENTHEOH = LoaiPhong.TIENTHEOH, MATRANGTHAI = PhongNghi.MATRANGTHAI, TENTRANGTHAI = TrangThai.TENTRANGTHAI, MALOAIPHONG = PhongNghi.MALOAIPHONG, TENLOAIPHONG = LoaiPhong.TENLOAIPHONG, MATINHTRANG = PhongNghi.MATINHTRANG, TENTINHTRANG = TinhTrang.TENTINHTRANG };

        public List<PhongNghiCustom> LoadDataTable
        (
            Int32? TangHotel,

            String LoaiPhong,

            String TinhTrang,

            String TrangThai
        )
        {
            IQueryable<PhongNghiCustom> Query = LoadDataTable();

            if (TangHotel.HasValue)
            {
                Int32 TangThu = TangHotel.Value;

                Query = Query.Where(x => x.TANGTHU == TangThu);
            }

            if (!String.IsNullOrEmpty(LoaiPhong))
            {
                Query = Query.Where(x => x.MALOAIPHONG == LoaiPhong);
            }

            if (!String.IsNullOrEmpty(TinhTrang))
            {
                Query = Query.Where(x => x.MATINHTRANG == TinhTrang);
            }

            if (!String.IsNullOrEmpty(TrangThai))
            {
                Query = Query.Where(x => x.MATRANGTHAI == TrangThai);
            }

            return Query.ToList();
        }

        public void Add(PHONGNGHI_TBL NewPhong)
        {
            Adapter.PHONGNGHI_TBL.Add(NewPhong);

            Adapter.SaveChanges();
        }

        public void Edit(PHONGNGHI_TBL NewPhong)
        {
            String MaSoPhong = NewPhong.MAPHONG;

            PHONGNGHI_TBL Row = Adapter.PHONGNGHI_TBL.FirstOrDefault(x => x.MAPHONG == MaSoPhong);

            Row.TENPHONG = NewPhong.TENPHONG;

            Row.TANGTHU = NewPhong.TANGTHU;

            Row.MALOAIPHONG = NewPhong.MALOAIPHONG;

            Row.MATINHTRANG = NewPhong.MATINHTRANG;

            Row.MATRANGTHAI = NewPhong.MATRANGTHAI;

            Adapter.SaveChanges();
        }

        public void Status(String MaSoPhong, String MaTrangThai)
        {
            PHONGNGHI_TBL Row = Adapter.PHONGNGHI_TBL.FirstOrDefault(x => x.MAPHONG == MaSoPhong);

            if (Row.MATRANGTHAI != "OCCUPIED")
            {
                Row.MATRANGTHAI = MaTrangThai;

                Adapter.SaveChanges();
            }
        }

        public void Remove(String MaSoPhong)
        {
            PHONGNGHI_TBL Row = Adapter.PHONGNGHI_TBL.FirstOrDefault(x => x.MAPHONG == MaSoPhong);

            Adapter.PHONGNGHI_TBL.Remove(Row);

            Adapter.SaveChanges();
        }

        public List<PhongNghiCustom> LoadDataTable(Int32 MaSoTang, String TrangThaiPhong)
        {
            var Query = LoadDataTable().Where(x => x.TANGTHU == MaSoTang);

            if (!String.IsNullOrEmpty(TrangThaiPhong))
            {
                Query = Query.Where(x => x.MATRANGTHAI == TrangThaiPhong);
            }

            return Query.ToList();
        }

        public bool Duplicate(String MaSoPhong)
        {
            return Adapter.PHONGNGHI_TBL.AsNoTracking().Any(x => x.MAPHONG == MaSoPhong);
        }

        public bool Referenced(String MaSoPhong)
        {
            return Adapter.PHONGDAT_TBL.AsNoTracking().Any(x => x.MAPHONG == MaSoPhong);
        }

        public List<PhongNghiCustom> SearchPhong(String Phong)
        {
            IQueryable<PhongNghiCustom> List = LoadDataTable();

            if (String.IsNullOrEmpty(Phong))
            {
                return null;
            }

            return List.AsNoTracking().Where(x => x.TENPHONG.Contains(Phong)).ToList();
        }

        public Int32 TongPhong()

        => Adapter.PHONGNGHI_TBL.AsNoTracking().Count();

        public Int32 CoRangBuoc()

                           => DaDuocDat() + DaCoNguoi();

        public Int32 DangCoSan()

        => Adapter.PHONGNGHI_TBL.AsNoTracking().Count(x => x.MATRANGTHAI == "AVAILABLE");

        public Int32 DaCoNguoi()

        => Adapter.PHONGNGHI_TBL.AsNoTracking().Count(x => x.MATRANGTHAI == "OCCUPIED");

        public Int32 DaDuocDat()

        => Adapter.PHONGNGHI_TBL.AsNoTracking().Count(x => x.MATRANGTHAI == "RESERVED");

        public Int32 DangNgung()

        => Adapter.PHONGNGHI_TBL.AsNoTracking().Count(x => x.MATRANGTHAI == "SUSPENDED");
    }
}