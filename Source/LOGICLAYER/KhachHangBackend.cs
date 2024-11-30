using DATALAYER;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LOGICLAYER
{
    public class KhachHangBackend
    {
        readonly QLKSEntities Adapter = new QLKSEntities();

        readonly PhongDatBackend PhongDatHandle = new();

        public IQueryable<KhachHangCustom> LoadDataTable()

        => from KH in Adapter.KHACHHANG_TBL.AsNoTracking()

           join QT in Adapter.QUOCTICH_TBL.AsNoTracking()

           on KH.MAQT equals QT.MAQT

           join GT in Adapter.GIOITINH_TBL.AsNoTracking()

           on KH.MAGT equals GT.MAGT

           select new KhachHangCustom
           {
               IDKHACH = KH.IDKHACH,

               HOVATEN = KH.HOVATEN,

               QUEQUAN = KH.QUEQUAN,

               EMAIL = KH.EMAIL,

               QUOCTICH = QT.QUOCTICH,

               MAGT = GT.MAGT,

               GIOITINH = GT.GIOITINH,

               MAQT = QT.MAQT,

               SOLIENHE = KH.SOLIENHE,
           };

        public List<KhachHangCustom> LoadDataTable(String GioiTinh, String QuocTich)
        {
            IQueryable<KhachHangCustom> GetListKH = LoadDataTable();

            if (!String.IsNullOrEmpty(GioiTinh))
            {
                GetListKH = GetListKH.Where(x => x.MAGT == GioiTinh);
            }

            if (!String.IsNullOrEmpty(QuocTich))
            {
                GetListKH = GetListKH.Where(x => x.MAQT == QuocTich);
            }

            return GetListKH.ToList();
        }

        public List<KhachHangCustom> GetBookingOrCheckedIn(String MaTrangThai)
        {
            IQueryable<DatPhongOCustom> Query = PhongDatHandle.LoadDataTable();

            if (!String.IsNullOrEmpty(MaTrangThai))
            {
                Query = Query.Where(x => x.MATRANGTHAI == MaTrangThai);
            }
            else
            {
                Query = Query.Where(x => x.MATRANGTHAI == "RESERVED"

                                    || x.MATRANGTHAI == "CHECKEDIN");
            }


            List<String> MaKhach = Query.Select(x => x.IDKHACH).Distinct().ToList();

            return LoadDataTable().Where(x => MaKhach.Contains(x.IDKHACH)).ToList();
        }

        public Boolean Duplicate(String IDKhach)

             => Adapter.KHACHHANG_TBL.AsNoTracking().Any(x => x.IDKHACH == IDKhach);

        public void Add(KHACHHANG_TBL NewKhach)
        {
            Adapter.KHACHHANG_TBL.Add(NewKhach);

            Adapter.SaveChanges();
        }

        public void Edit(KHACHHANG_TBL NewKhach)
        {
            String IDKhach = NewKhach.IDKHACH;

            KHACHHANG_TBL Row = Adapter.KHACHHANG_TBL.FirstOrDefault(x => x.IDKHACH == IDKhach);

            Row.HOVATEN = NewKhach.HOVATEN;

            Row.MAGT = NewKhach.MAGT;

            Row.MAQT = NewKhach.MAQT;

            Row.SOLIENHE = NewKhach.SOLIENHE;

            Row.EMAIL = NewKhach.EMAIL;

            Row.QUEQUAN = NewKhach.QUEQUAN;

            Adapter.SaveChanges();
        }

        public int SoLuongKhach()

                  => Adapter.KHACHHANG_TBL.AsNoTracking().Count();

        public List<KhachHangCustom> SearchKhach(String TenKhach)
        {
            IQueryable<KhachHangCustom> GetList = LoadDataTable();

            if (String.IsNullOrEmpty(TenKhach))
            {
                return null;
            }

            return GetList.Where(x => x.HOVATEN.Contains(TenKhach)).ToList();
        }

        public KhachHangCustom GetKhachHang(String IDKhach)

                => LoadDataTable().FirstOrDefault(x => x.IDKHACH == IDKhach);
    }
}