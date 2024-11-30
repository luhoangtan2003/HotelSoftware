using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class HoaDonPhongBackend
    {
        readonly QLKSEntities Adapter = new QLKSEntities();

        public IQueryable<HoaDonPhongCustom> LoadDataTable()

        => from HD in Adapter.HOADONPHONG_TBL.AsNoTracking()

           join TT in Adapter.TRANGTHAIHD_TBL.AsNoTracking()

           on HD.MATRANGTHAI equals TT.MATRANGTHAI

           join TD in Adapter.PAYMENTTIME_TBL.AsNoTracking()

           on HD.MATHOIDIEM equals TD.MATHOIDIEM

           join PD in Adapter.PHONGDAT_TBL.AsNoTracking()

           on HD.MAPHONGDAT equals PD.MAPHONGDAT

           join PO in Adapter.PHONGNGHI_TBL.AsNoTracking()

           on PD.MAPHONG equals PO.MAPHONG

           join KH in Adapter.KHACHHANG_TBL.AsNoTracking()

           on PD.IDKHACH equals KH.IDKHACH

           select new HoaDonPhongCustom { MAHOADON = HD.MAHOADON, MAPHONGDAT = PD.MAPHONGDAT, MAPHONG = PO.MAPHONG, TENPHONG = PO.TENPHONG, IDKHACH = KH.IDKHACH, HOVATEN = KH.HOVATEN, MATRANGTHAI = TT.MATRANGTHAI, TENTRANGTHAI = TT.TENTRANGTHAI, GIAMGIA = HD.GIAMGIA, GIATRIBANDAU = HD.GIATRIBANDAU, GIATHANHTOAN = HD.GIATHANHTOAN, NGAYTHANHTOAN = HD.NGAYTHANHTOAN, MATHOIDIEM = TD.MATHOIDIEM, TENTHOIDIEM = TD.TENTHOIDIEM };

        public DateTime? GetDateLimitPoint(String TimeLine)
        {
            if (TimeLine == "Today Onward")
            {
                return DateTime.Now;
            }
            else if (TimeLine == "One Week")
            {
                return DateTime.Now.AddDays(-007);
            }
            else if (TimeLine == "One Month")
            {
                return DateTime.Now.AddMonths(-1);
            }
            else if (TimeLine == "One Year")
            {
                return DateTime.Now.AddYears(-01);
            }
            else return null;
        }

        public List<HoaDonPhongCustom> LoadDataTable
        (
            String Timeline,

            String IDKhach,

            String MaPhong,

            String ThoiDiem,

            String TrangThai
        )
        {
            IQueryable<HoaDonPhongCustom> Query = LoadDataTable();

            DateTime? GetLimitPoint = GetDateLimitPoint(Timeline);

            if (GetLimitPoint.HasValue)
            {
                DateTime Border = GetLimitPoint.Value.Date;

                Query = Query.Where(x => x.NGAYTHANHTOAN >= Border);
            }

            if (!String.IsNullOrEmpty(ThoiDiem))
            {
                Query = Query.Where(x => x.MATHOIDIEM == ThoiDiem);
            }

            if (!String.IsNullOrEmpty(TrangThai))
            {
                Query = Query.Where(x => x.MATRANGTHAI == TrangThai);
            }

            if (!String.IsNullOrEmpty(IDKhach))
            {
                Query = Query.Where(x => x.IDKHACH == IDKhach);
            }

            if (!String.IsNullOrEmpty(MaPhong))
            {
                Query = Query.Where(x => x.MAPHONG == MaPhong);
            }

            return Query.ToList();
        }

        public void Add(HOADONPHONG_TBL NewHD)
        {
            Adapter.HOADONPHONG_TBL.Add(NewHD);

            Adapter.SaveChanges();
        }

        public void Remove(String MaHoaDonPhong)
        {
            HOADONPHONG_TBL Row = Adapter.HOADONPHONG_TBL.FirstOrDefault(x => x.MAHOADON == MaHoaDonPhong);

            Adapter.HOADONPHONG_TBL.Remove(Row);

            Adapter.SaveChanges();
        }

        public HOADONPHONG_TBL GetHoaDonPhong(String MaHoaDonPhong)

                => Adapter.HOADONPHONG_TBL.AsNoTracking().FirstOrDefault(x => x.MAHOADON == MaHoaDonPhong);

        public List<HOADONPHONG_TBL> HoaDonPhongTheoNam(Int32 Year)
        {
            return Adapter.HOADONPHONG_TBL.AsNoTracking().Where(x => x.NGAYTHANHTOAN.Year == Year
                                                               &&
                                                               x.MATRANGTHAI == "PAID").ToList();
        }

        public List<HOADONPHONG_TBL> HoaDonPhongTheoThang
        (
            Int32 Month, Int32 Year
        )
        {
            return Adapter.HOADONPHONG_TBL.AsNoTracking().Where(x => x.NGAYTHANHTOAN.Year == Year
                                                               &&
                                                               x.NGAYTHANHTOAN.Month == Month
                                                               &&
                                                               x.MATRANGTHAI == "PAID").ToList();
        }

        public HoaDonPhongCustom GetHoaDon(String MaHoaDon)

               => LoadDataTable().FirstOrDefault(x => x.MAHOADON == MaHoaDon);

        public List<HoaDonPhongCustom> SearchHoaDon(String TenKhach)
        {
            IQueryable<HoaDonPhongCustom> GetList = LoadDataTable();

            if (String.IsNullOrEmpty(TenKhach))
            {
                return null;
            }

            return GetList.Where(x => x.HOVATEN.Contains(TenKhach)).ToList();
        }
    }
}