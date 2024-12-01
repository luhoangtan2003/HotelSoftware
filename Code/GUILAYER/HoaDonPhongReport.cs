using DATALAYER;
using LOGICLAYER;
using System;

namespace GUILAYER
{
    public partial class HoaDonPhongReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonPhongReport(String MaHD)
        {
            InitializeComponent();

            MaHoaDon.Text = MaHD;
        }

        readonly KhachHangBackend KhachHangHandle = new();

        readonly HoaDonPhongBackend HoaDonHandle = new();

        readonly PhongDatBackend BookPhongHandle = new();

        HoaDonPhongCustom HoaDon;

        DatPhongOCustom Booked;

        KhachHangCustom KhachHang;

        private void HoaDonPhongReport_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HoaDon = HoaDonHandle.GetHoaDon(MaHoaDon.Text);

            Booked = BookPhongHandle.GetDatPhong(HoaDon.MAPHONGDAT);

            MaKhach.Text = Booked.IDKHACH;

            KhachHang = KhachHangHandle.GetKhachHang(MaKhach.Text);

            HoVaTen.Text = KhachHang.HOVATEN;

            LienHe.Text = KhachHang.SOLIENHE;

            QueQuan.Text = KhachHang.QUEQUAN;

            Email.Text = KhachHang.EMAIL;

            QuocTich.Text = KhachHang.QUOCTICH;

            LoaiHinh.Text = Booked.TENLOAIHINH;

            TenPhong.Text = Booked.TENPHONG;

            NgayHD.Text = Booked.NGAYDAT.ToString();

            NgayDat.Text = Booked.NGAYDAT.ToString();

            NgayLay.Text = Booked.NGAYLAY.ToString();

            NgayTra.Text = Booked.NGAYTRA.ToString();

            ThoiHan.Text = Booked.THOIHAN.ToString();

            NgayThanhToan.Text = HoaDon.NGAYTHANHTOAN.ToString();

            GiaPhongBanDau.Text = HoaDon.GIATRIBANDAU.ToString();

            GiamGia.Text = HoaDon.GIAMGIA.ToString();

            GiaCanThanhToan.Text = HoaDon.GIATHANHTOAN.ToString();

            LucTraTien.Text = HoaDon.TENTHOIDIEM;

            TrangThai.Text = HoaDon.TENTRANGTHAI;

            SoDienThoaiKS.Text = Environment.GetEnvironmentVariable("PhoneNumber", EnvironmentVariableTarget.User);

            DiaChiMailKS.Text = Environment.GetEnvironmentVariable("MailUsername", EnvironmentVariableTarget.User);
        }
    }
}