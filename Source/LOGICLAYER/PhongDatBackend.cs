using DATALAYER;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LOGICLAYER
{
    public class PhongDatBackend
    {
        readonly QLKSEntities Adapter = new QLKSEntities();

        readonly HoaDonPhongBackend HoaDonHandle = new();

        public IQueryable<DatPhongOCustom> LoadDataTable()

        => from DatPhongNghi in Adapter.PHONGDAT_TBL.AsNoTracking()

           join TrangThai in Adapter.TRANGTHAIDP_TBL.AsNoTracking()

           on DatPhongNghi.MATRANGTHAI equals TrangThai.MATRANGTHAI

           join KhachHang in Adapter.KHACHHANG_TBL.AsNoTracking()

           on DatPhongNghi.IDKHACH equals KhachHang.IDKHACH

           join Phongnghi in Adapter.PHONGNGHI_TBL.AsNoTracking()

           on DatPhongNghi.MAPHONG equals Phongnghi.MAPHONG

           join LoaiHinhDP in Adapter.LOAIHINHDP_TBL.AsNoTracking()

           on DatPhongNghi.MALOAIHINH equals LoaiHinhDP.MALOAIHINH

           select new DatPhongOCustom { IDKHACH = KhachHang.IDKHACH, HOVATEN = KhachHang.HOVATEN, MAPHONG = Phongnghi.MAPHONG, TENPHONG = Phongnghi.TENPHONG, GHICHU = DatPhongNghi.GHICHU, THOIHAN = DatPhongNghi.THOIHAN, NGAYDAT = DatPhongNghi.NGAYDAT, NGAYLAY = DatPhongNghi.NGAYLAY, NGAYTRA = DatPhongNghi.NGAYTRA, GIAPHONG = DatPhongNghi.GIAPHONG, MAPHONGDAT = DatPhongNghi.MAPHONGDAT, MALOAIHINH = LoaiHinhDP.MALOAIHINH, TENLOAIHINH = LoaiHinhDP.TENLOAIHINH, MATRANGTHAI = TrangThai.MATRANGTHAI, TENTRANGTHAI = TrangThai.TENTRANGTHAI };

        public DateTime? GetDateLimitPoint(String TimeLine)
        {
            if (TimeLine == "Today")
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

        public List<DatPhongOCustom> LoadDataTable
        (
            String Timeline,

            String IDKhach,

            String MaPhong,

            String LoaiHinhDP,

            String TrangThai
        )
        {
            IQueryable<DatPhongOCustom> Query = LoadDataTable();

            DateTime? LimitPoint = GetDateLimitPoint(Timeline);

            if (LimitPoint.HasValue)
            {
                DateTime Border = LimitPoint.Value.Date;

                Query = Query.Where(x => x.NGAYDAT >= Border);
            }

            if (!String.IsNullOrEmpty(IDKhach))
            {
                Query = Query.Where(x => x.IDKHACH == IDKhach);
            }

            if (!String.IsNullOrEmpty(MaPhong))
            {
                Query = Query.Where(x => x.MAPHONG == MaPhong);
            }

            if (!String.IsNullOrEmpty(LoaiHinhDP))
            {
                Query = Query.Where(x => x.MALOAIHINH == LoaiHinhDP);
            }

            if (!String.IsNullOrEmpty(TrangThai))
            {
                Query = Query.Where(x => x.MATRANGTHAI == TrangThai);
            }

            return Query.ToList();
        }

        public List<DatPhongOCustom> LoadDataTable
        (
            String KhachHang,

            String TrangThai
        )
        {
            IQueryable<DatPhongOCustom> Query = LoadDataTable();

            if (!String.IsNullOrEmpty(KhachHang))
            {
                Query = Query.Where(x => x.IDKHACH == KhachHang);
            }

            if (!String.IsNullOrEmpty(TrangThai))
            {
                Query = Query.Where(x => x.MATRANGTHAI == TrangThai);
            }
            else
            {
                Query = Query.Where(x => x.MATRANGTHAI == "RESERVED"

                                    || x.MATRANGTHAI == "CHECKEDIN");
            }

            return Query.ToList();
        }

        public void Add(PHONGDAT_TBL NewPhongDat)
        {
            Adapter.PHONGDAT_TBL.Add(NewPhongDat);

            Adapter.SaveChanges();
        }

        public List<DatPhongOCustom> SearchKhach(String TenKhach)
        {
            IQueryable<DatPhongOCustom> GetList = LoadDataTable();

            if (String.IsNullOrEmpty(TenKhach))
            {
                return null;
            }

            return GetList.Where(x => x.HOVATEN.Contains(TenKhach))

                          .ToList();
        }

        public Boolean Overlapping(DateTime StartA, DateTime EndA, DateTime StartB, DateTime EndB)
        {
            return StartA <= EndB && StartB <= EndA;
        }

        public Double TurnoverTime(DateTime StartA, DateTime EndA, DateTime StartB, DateTime EndB)
        {
            TimeSpan Distance = TimeSpan.Zero;

            if (StartB > EndA)
            {
                Distance = StartB - EndA;
            }

            if (StartA > EndB)
            {
                Distance = StartA - EndB;
            }

            return Distance.TotalMinutes;
        }

        public List<DatPhongOCustom> Conflict(String MaPhong, DateTime NgayLay, DateTime NgayTra)
        {
            List<DatPhongOCustom> Reserved = LoadDataTable().Where(x => x.MAPHONG == MaPhong &&

                                 (x.MATRANGTHAI == "RESERVED" || x.MATRANGTHAI == "CHECKEDIN"))

                                   .ToList();

            if (!Reserved.Any()) return null;

            List<DatPhongOCustom> DanhSachBiXungDot = new();

            foreach (DatPhongOCustom LichDaBook in Reserved)
            {
                Boolean NoOverlap = !Overlapping(NgayLay, NgayTra, LichDaBook.NGAYLAY, LichDaBook.NGAYTRA);

                Double BufferTime = TurnoverTime(NgayLay, NgayTra, LichDaBook.NGAYLAY, LichDaBook.NGAYTRA);

                if (NoOverlap && BufferTime >= 45)
                {
                    continue;
                }

                DanhSachBiXungDot.Add(LichDaBook);
            }

            return DanhSachBiXungDot;
        }

        public int NumReserved(String MaKhach)

                                => Adapter.PHONGDAT_TBL.AsNoTracking().Count(x => x.IDKHACH == MaKhach);


        public void Cancel(String MaPhongDat)
        {
            PHONGDAT_TBL GetRow = Adapter.PHONGDAT_TBL.FirstOrDefault(x => x.MAPHONGDAT == MaPhongDat);

            GetRow.MATRANGTHAI = "CANCELED";

            String MaPhong = GetRow.MAPHONG;

            Int32 Reserving = Adapter.PHONGDAT_TBL.AsNoTracking().Count(x => x.MAPHONG == MaPhong &&

                                                                        x.MATRANGTHAI == "RESERVED");

            Int32 InEffect = Adapter.PHONGDAT_TBL.AsNoTracking().Count(x => x.MAPHONG == MaPhong &&

                                                                       x.MATRANGTHAI == "CHECKEDIN");

            if (Reserving == 1 && InEffect == 0)
            {
                PHONGNGHI_TBL Booked = Adapter.PHONGNGHI_TBL.FirstOrDefault(x => x.MAPHONG == MaPhong);

                Adapter.Entry(Booked).Reload();

                Booked.MATRANGTHAI = "AVAILABLE";
            }

            Adapter.SaveChanges();
        }

        public DatPhongOCustom InEffect(String MaPhong)
        {
            List<DatPhongOCustom> InEffect = LoadDataTable().Where(x => x.MATRANGTHAI != "CHECKEDOUT"

                                                                   && x.MATRANGTHAI != "CANCELED"

                                                                   && x.MAPHONG == MaPhong).ToList();

            if (InEffect.Any())
            {
                DatPhongOCustom InTheRoom = InEffect.FirstOrDefault(x => x.MATRANGTHAI == "CHECKEDIN");

                return !HamChucNang.IsFieldNull(InTheRoom) ? InTheRoom

                                                           : InEffect.OrderBy(x => x.NGAYLAY).First();
            }

            return null;
        }

        public List<PHONGDAT_TBL> PhongDangDat(String IDKhach)
        {
            return Adapter.PHONGDAT_TBL.Where(x => x.IDKHACH == IDKhach && x.MATRANGTHAI == "RESERVED")

                                                                                             .ToList();
        }

        public List<PHONGDAT_TBL> PhongDangLay(String IDKhach)
        {
            return Adapter.PHONGDAT_TBL.Where(x => x.IDKHACH == IDKhach && x.MATRANGTHAI == "CHECKEDIN")

                                                                                              .ToList();
        }

        public Boolean DenHan(DateTime Now, DateTime Deadline)
        {
            if (Now > Deadline)
            {
                return false;
            }

            Double TimePeriod = (Deadline - Now).TotalMinutes;

            return TimePeriod <= 15;
        }

        public Boolean QuaHan(DateTime Now, DateTime Deadline)
        {
            return Now > Deadline;
        }

        public Tuple<List<DatPhongOCustom>, List<DatPhongOCustom>> DanhSachHanLayPhong()
        {
            IQueryable<DatPhongOCustom> Query = LoadDataTable().Where(x => x.MATRANGTHAI == "RESERVED");

            List<DatPhongOCustom> SapDenHan = Query.ToList().Where(x => DenHan(DateTime.Now, x.NGAYLAY))

                                                   .ToList();

            List<DatPhongOCustom> QuaHanLay = Query.ToList().Where(x => QuaHan(DateTime.Now, x.NGAYLAY))

                                                   .ToList();

            return Tuple.Create(SapDenHan, QuaHanLay);
        }

        public Tuple<List<DatPhongOCustom>, List<DatPhongOCustom>> DanhSachHanTraPhong()
        {
            IQueryable<DatPhongOCustom> Query = LoadDataTable().Where(x => x.MATRANGTHAI == "CHECKEDIN");

            List<DatPhongOCustom> SapDenHan = Query.ToList().Where(x => DenHan(DateTime.Now, x.NGAYTRA))

                                                   .ToList();

            List<DatPhongOCustom> QuaHanTra = Query.ToList().Where(x => QuaHan(DateTime.Now, x.NGAYTRA))

                                                   .ToList();

            return Tuple.Create(SapDenHan, QuaHanTra);
        }

        public Boolean CoPhongDangLay(String IDKhach) => PhongDangLay(IDKhach).Any();

        public Boolean CoPhongDangDat(String IDKhach) => PhongDangDat(IDKhach).Any();

        public Boolean ChoPhepNhanPhong(DateTime NgayLay)
        {
            if (NgayLay <= DateTime.Now)
            {
                return true;
            }

            TimeSpan Remaining = NgayLay - DateTime.Now;

            if (Remaining.TotalMinutes <= 15)
            {
                return true;
            }

            return false;
        }

        public DatPhongOCustom GetDatPhong(String MaDatPhong)

                                        => LoadDataTable().FirstOrDefault(x => x.MAPHONGDAT == MaDatPhong);

        public Tuple<List<DatPhongOCustom>, List<DatPhongOCustom>> XacNhanKhachHangLayPhong(String IDKhach)
        {
            List<PHONGDAT_TBL> GetPhongCho = PhongDangDat(IDKhach);

            List<DatPhongOCustom> KhongTheNhan = new();

            List<DatPhongOCustom> NhanPhongRoi = new();

            foreach (PHONGDAT_TBL Phong in GetPhongCho)
            {
                if (ChoPhepNhanPhong(Phong.NGAYLAY))
                {
                    Phong.MATRANGTHAI = "CHECKEDIN";

                    String MaPhong = Phong.MAPHONG;

                    PHONGNGHI_TBL Booked = Adapter.PHONGNGHI_TBL.FirstOrDefault(x => x.MAPHONG == MaPhong);

                    Booked.MATRANGTHAI = "OCCUPIED";

                    String MaHD = Phong.MAPHONGDAT;

                    HOADONPHONG_TBL GetHD = Adapter.HOADONPHONG_TBL.FirstOrDefault(x => x.MAHOADON == MaHD);

                    if (GetHD.MATHOIDIEM == "PAYNOW")
                    {
                        GetHD.MATRANGTHAI = "PAID";
                    }

                    NhanPhongRoi.Add(GetDatPhong(Phong.MAPHONGDAT));
                }
                else
                {
                    KhongTheNhan.Add(GetDatPhong(Phong.MAPHONGDAT));
                }
            }

            Adapter.SaveChanges();

            return Tuple.Create(NhanPhongRoi, KhongTheNhan);
        }

        public Boolean HuyTatCaPhongDangDat(String IDKhach)
        {
            List<PHONGDAT_TBL> GetPhongCho = PhongDangDat(IDKhach);

            GetPhongCho.ForEach(Phong => Cancel(Phong.MAPHONGDAT));

            IEnumerable<String> MaHoaDon = GetPhongCho.Select(x => x.MAPHONGDAT);

            List<HOADONPHONG_TBL> GetHoaDon = Adapter.HOADONPHONG_TBL

                                      .AsNoTracking()

                                      .Where(x => MaHoaDon.Contains(x.MAHOADON))

                                      .ToList();

            GetHoaDon.ForEach(HoaDon => HoaDonHandle.Remove(HoaDon.MAPHONGDAT));

            return GetPhongCho.Any();
        }

        public void XacNhanKhachHangTraPhong(DataGridViewSelectedRowCollection DanhSachPhongDatDuocChon)
        {
            List<PHONGDAT_TBL> GetPhongDangNhan = new List<PHONGDAT_TBL>();

            foreach (DataGridViewRow Row in DanhSachPhongDatDuocChon)
            {
                String DatPhong = Row.Cells["MAPHONGDAT"].Value.ToString();

                GetPhongDangNhan.Add(Adapter.PHONGDAT_TBL.FirstOrDefault(x => x.MAPHONGDAT == DatPhong));
            }

            foreach (PHONGDAT_TBL PhongDat in GetPhongDangNhan)
            {
                PhongDat.MATRANGTHAI = "CHECKEDOUT";

                String MaPhong = PhongDat.MAPHONG;

                PHONGNGHI_TBL Booked = Adapter.PHONGNGHI_TBL.FirstOrDefault(x => x.MAPHONG == MaPhong);

                Booked.MATRANGTHAI = "AVAILABLE";

                String MaHD = PhongDat.MAPHONGDAT;

                HOADONPHONG_TBL GetHD = Adapter.HOADONPHONG_TBL.FirstOrDefault(x => x.MAHOADON == MaHD);

                if (GetHD.MATHOIDIEM != "PAYNOW")
                {
                    GetHD.MATRANGTHAI = "PAID";
                }
            }

            Adapter.SaveChanges();
        }

        public Boolean Notice(String MaDatPhong, String News)
        {
            NoticeToCustomers Sender = new();

            DatPhongOCustom Booking = GetDatPhong(MaDatPhong);

            String MaKhach = Booking.IDKHACH;

            String MaPhong = Booking.MAPHONG;

            KHACHHANG_TBL KhachHang = Adapter.KHACHHANG_TBL.AsNoTracking()

                                                           .FirstOrDefault(x => x.IDKHACH == MaKhach);

            PHONGNGHI_TBL PhongNghi = Adapter.PHONGNGHI_TBL.AsNoTracking()

                                                           .FirstOrDefault(x => x.MAPHONG == MaPhong);

            String Loai = PhongNghi.MALOAIPHONG;

            LOAIPHONG_TBL LoaiPhong = Adapter.LOAIPHONG_TBL.AsNoTracking()

                                                           .FirstOrDefault(x => x.MALOAIPHONG == Loai);

            String CustomerName = KhachHang.HOVATEN;

            String CustomerEmail = KhachHang.EMAIL;

            if (Sender.IsValidEmail(CustomerEmail))
            {
                BodyBuilder Content = null;

                MimeMessage Mailbox = null;

                switch (News)
                {
                    case "RESERVED":

                        Content = Sender.NoiDungDatPhongThanhCong(KhachHang, LoaiPhong, Booking);

                        break;

                    case "OCCUPIED":

                        Content = Sender.NoiDungXacNhanNhanPhong(Booking);

                        break;

                    case "CANCELED":

                        Content = Sender.NoiDungXacNhanBoDatPhong(Booking);

                        break;
                }

                Mailbox = Sender.Building(CustomerName, CustomerEmail, "THÔNG BÁO!!!", Content);

                Sender.SendMail(Mailbox);

                return true;
            }

            return false;
        }
    }
}