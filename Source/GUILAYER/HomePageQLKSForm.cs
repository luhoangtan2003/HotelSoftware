using DATALAYER;
using DevExpress.XtraSplashScreen;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class HomePageQLKSForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomePageQLKSForm()
        {
            SetAlertFormPosition();

            InitializeComponent();
        }

        PhongDatBackend PhongDatHandle = new();

        Boolean PopOnSound = true;

        ChuongThongBaoForm AlertPopOn = new();

        public void SetAlertFormPosition()
        {
            Screen Scr = Screen.PrimaryScreen;

            Int32 Width = 0000, Height = 0000;

            (Width, Height) = (Scr.WorkingArea.Width - AlertPopOn.Width, Scr.WorkingArea.Height - AlertPopOn.Height);

            AlertPopOn.Location = new Point(Width, Height);
        }

        private void OpenForm(Type TypeForm)
        {
            Form C = Array.Find(MdiChildren, I => I.GetType() == TypeForm);

            if (!HamChucNang.IsFieldNull(C))
            {
                C.Activate();
            }
            else
            {
                Form NewSubForm = (Form)Activator.CreateInstance(TypeForm);

                NewSubForm.MdiParent = this;

                SplashScreenManager.ShowForm(typeof(ProgressLoadingForm));

                Thread.Sleep(100);

                NewSubForm.Show();

                SplashScreenManager.CloseForm();
            }
        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            Tuple<List<DatPhongOCustom>, List<DatPhongOCustom>> HanLayPhong = PhongDatHandle.DanhSachHanLayPhong();

            ListDenHanLayPhong.DataSource = HanLayPhong.Item1;

            ListQuaHanLayPhong.DataSource = HanLayPhong.Item2;

            Tuple<List<DatPhongOCustom>, List<DatPhongOCustom>> HanTraPhong = PhongDatHandle.DanhSachHanTraPhong();

            ListDenHanTraPhong.DataSource = HanTraPhong.Item1;

            ListQuaHanTraPhong.DataSource = HanTraPhong.Item2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RealTime.Start();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Focused)
            {
                Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                PopOnSound = !PopOnSound;
            }
        }

        private void SourceChanged(object sender, EventArgs e)
        {
            Int32 A = ListDenHanLayPhong.ItemCount;

            Int32 B = ListQuaHanLayPhong.ItemCount;

            Int32 C = ListDenHanTraPhong.ItemCount;

            Int32 D = ListQuaHanTraPhong.ItemCount;

            if (A > 0 || B > 0 || C > 0 || D > 0)
            {
                if (PopOnSound)
                {
                    SystemSounds.Asterisk.Play();
                }

                if (!AlertPopOn.Visible)
                {
                    AlertPopOn.Show();
                }
            }
            else
            {
                if (AlertPopOn.Visible)
                {
                    AlertPopOn.Hide();
                }
            }
        }

        private void QuanLyTangHotel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(TangHotelForm));
        }

        private void QuanLyPhongNghi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(PhongNghiForm));
        }

        private void QuanLyKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(KhachHangForm));
        }

        private void DichVuDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(DatPhongNghiForm));
        }

        private void NhanVaTraPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(LayVaTraPhongForm));
        }

        private void QuanLyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(DichVuYeuCauForm));
        }

        private void YeuCauDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(YeuCauDichVuForm));
        }

        private void QuanLyHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(ThanhToanBillForm));
        }

        private void QuanLyBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(BaoCaoLoiNhuanForm));
        }

        private void QuanLyLoaiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(LoaiPhongNghiForm));
        }

        private void KhoiPhucSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(KhoiPhucSaoLuuForm));
        }

        private void YeuCauDoiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(ChuyenPhongForm));
        }

        private void QuanLyMailbox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(QuanLyMailboxForm));
        }

        private void QuanTriNhanSu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(QuanTriNhanSuForm));
        }

        private void QuanLyLoaiDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(LoaiDichVuForm));
        }

        private void HotelInformation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinKhachSan InfoAcc = new();

            InfoAcc.ShowDialog();
        }
    }
}