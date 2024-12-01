using DATALAYER;
using DevExpress.XtraBars.Alerter;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GUILAYER
{
    public partial class ThongTinNhanPhong : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinNhanPhong(Object IDKhach)
        {
            InitializeComponent();

            KhachHang_SLUE.EditValue = IDKhach;
        }

        readonly KhachHangBackend KhachHangHandle = new();

        readonly PhongDatBackend BookPhongOHandle = new();

        readonly HoaDonPhongBackend HoaDonHandle = new();

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDKhach.Text.Trim()))
            {
                HamChucNang.ShowError("Mã số khách rỗng");

                return;
            }

            if (IDKhach.Text.Trim() != KhachHang_SLUE.EditValue.ToString())
            {
                HamChucNang.ShowError("Mã số CCCD/CMND thì không hợp lệ");

                return;
            }

            Tuple<List<DatPhongOCustom>, List<DatPhongOCustom>> Result = BookPhongOHandle.XacNhanKhachHangLayPhong(IDKhach.Text.Trim());

            List<DatPhongOCustom> NhanPhongRoi = Result.Item1;

            List<DatPhongOCustom> KhongTheNhan = Result.Item2;

            AlertInfo BuildInfo;

            String Message;

            if (KhongTheNhan.Any())
            {
                foreach (DatPhongOCustom Phong in KhongTheNhan)
                {
                    Message = $"CHƯA ĐẾN THỜI HẠN LẤY {Phong.TENPHONG} - XIN VUI LÒNG KIÊN NHẪN CHỜ";

                    BuildInfo = new AlertInfo("THÔNG BÁO", Message, Properties.Resources.NotGranted);

                    ThongBaoDatPhong.Show(Owner, BuildInfo);
                }
            }
            if (NhanPhongRoi.Any())
            {
                foreach (DatPhongOCustom Phong in NhanPhongRoi)
                {
                    String Name = KhachHang_SLUE.Properties.GetDisplayText(KhachHang_SLUE.EditValue);

                    Boolean NotificationSent = BookPhongOHandle.Notice(Phong.MAPHONGDAT, "OCCUPIED");
                }

                HamChucNang.CapNhatBangThongKe();

                HamChucNang.CapNhatCheckInOut();

                HamChucNang.CapNhatBangPhong();

                HamChucNang.CapNhatBookPhong();

                HamChucNang.CapNhatBangHoaDonPhong();
            }

            Close();
        }

        private void DinhDangKhungThongBao_BeforeFormShow(object sender, AlertFormEventArgs e)

                                                     => e.AlertForm.Size = new Size(450, 150);

        private void FormLoading(object sender, EventArgs e)

            => KhachHang_SLUE.Properties.DataSource = KhachHangHandle.LoadDataTable().ToList();
    }
}