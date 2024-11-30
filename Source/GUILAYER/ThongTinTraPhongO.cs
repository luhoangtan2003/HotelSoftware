using DATALAYER;
using DevExpress.XtraBars.Alerter;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinTraPhongO : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinTraPhongO(Object IDKhach)
        {
            InitializeComponent();

            KhachHang_SLUE.EditValue = IDKhach;
        }

        readonly KhachHangBackend KhachHangHandle = new();

        readonly PhongDatBackend BookPhongOHandle = new();

        readonly HoaDonPhongBackend HoaDonHandle = new();

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (HamChucNang.ShowAlert("Xác nhận lấy lại phòng") == DialogResult.OK)
            {
                BookPhongOHandle.XacNhanKhachHangTraPhong(BangDuLieu.SelectedRows);

                HamChucNang.CapNhatBangThongKe();

                HamChucNang.CapNhatCheckInOut();

                HamChucNang.CapNhatBangPhong();

                HamChucNang.CapNhatBookPhong();

                HamChucNang.CapNhatBangHoaDonPhong();

                Close();
            }
        }

        private void FormLoading(object sender, EventArgs e)
        {
            KhachHang_SLUE.Properties.DataSource = KhachHangHandle.LoadDataTable().ToList();

            String GetIDKhach = KhachHang_SLUE.EditValue.ToString();

            BangDuLieu.DataSource = BookPhongOHandle.LoadDataTable(GetIDKhach, "CHECKEDIN");

            SoPhongDangDung.Value = BangDuLieu.Rows.Count;
        }

        private void DanhSachCacPhongDaChon(object sender, EventArgs e)
        {
            SoPhongThanhToan.Value = BangDuLieu.SelectedRows.Count;

            List<HOADONPHONG_TBL> ListHoaDon = new();

            foreach (DataGridViewRow Row in BangDuLieu.SelectedRows)
            {
                String ID = Row.Cells["MAPHONGDAT"].Value.ToString();

                HOADONPHONG_TBL HD = HoaDonHandle.GetHoaDonPhong(ID);

                ListHoaDon.Add(HD);
            }

            TongTienPhong.Value = ListHoaDon.Sum(x => x.GIATHANHTOAN);
        }

        private void DinhDangKhungThongBao_BeforeFormShow(object sender, AlertFormEventArgs e)

                                                     => e.AlertForm.Size = new Size(450, 150);
    }
}