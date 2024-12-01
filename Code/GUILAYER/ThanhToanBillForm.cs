using DATALAYER;
using DevExpress.XtraReports.UI;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThanhToanBillForm : DevExpress.XtraEditors.XtraForm
    {
        public ThanhToanBillForm()
        {
            InitializeComponent();

            HamChucNang.BangHoaDonDatDV += BangHoaDonDatDVLoading;

            HamChucNang.BangHoaDonPhong += BangHoaDonPhongLoading;

            HamChucNang.PhongDatPhong += PhongSLUELoading;

            HamChucNang.BangKhach += KhachSLUELoading;
        }

        readonly PaymentTimeBackend PaymentTimeHandle = new();

        readonly HoaDonPhongBackend HoaDonPhongHandle = new();

        readonly KhachHangBackend KhachHangHandle = new();

        readonly PhongNghiBackend PhongNghiHandle = new();

        readonly TrangThaiHDBackend TrangThaiHandle = new();

        List<HoaDonPhongCustom> Save, Filter;

        String TimeLine;

        String KhachHang;

        String PhongNghi;

        String ThoiDiem;

        String TrangThai;

        public void BangHoaDonPhongLoading()
        {
            Save = HoaDonPhongHandle.LoadDataTable(TimeLine, KhachHang, PhongNghi, ThoiDiem, TrangThai);

            BangHoaDonPhongO.DataSource = Save;

            BangHoaDonPhongO.ClearSelection();
        }

        public void BangHoaDonDatDVLoading()
        {
            //Tạm thời bỏ qua phần load này
        }

        private void HoaDonSearchAfterTyping(object sender, EventArgs e)
        {
            Lock.Stop();

            List<HoaDonPhongCustom> Value = HoaDonPhongHandle.SearchHoaDon(HoaDonSearch.Text.Trim());

            if (HamChucNang.IsFieldNull(Value))
            {
                BangHoaDonPhongO.DataSource = Save;
            }
            else
            {
                BangHoaDonPhongO.DataSource = Value;

                Filter = Value;
            }
        }

        private void HoaDonSearch_TextChanged(object sender, EventArgs e)
        {
            Lock.Stop(); Lock.Start();
        }

        public void PhongSLUELoading()
        {
            PhongNghi_SLUE.Properties.DataSource = PhongNghiHandle.LoadDataTable().ToList();
        }

        public void KhachSLUELoading()
        {
            KhachHang_SLUE.Properties.DataSource = KhachHangHandle.LoadDataTable().ToList();
        }

        private void NutIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object MaHoaDon = BangHoaDonPhongO.SelectedRows[0].Cells["MAHOADONHDPN"].Value;

            HoaDonPhongReport NewHoaDonPhongO = new HoaDonPhongReport(MaHoaDon.ToString());

            NewHoaDonPhongO.ShowRibbonPreview();
        }

        public void DataTableLoading()
        {
            BangHoaDonPhongLoading();

            BangHoaDonDatDVLoading();
        }

        private void ThanhToanBillForm_Load(object sender, EventArgs e)
        {
            PaymentTimes.Properties.DataSource = PaymentTimeHandle.LoadDataTable();

            TrangThai_SLUE.Properties.DataSource = TrangThaiHandle.LoadDataTable();

            TimeLine = TimeLine_CBB.EditValue.ToString();

            DataTableLoading();

            PhongSLUELoading();

            KhachSLUELoading();
        }

        private void TimeLine_EditValueChanged(object sender, EventArgs e)
        {
            TimeLine = TimeLine_CBB.EditValue.ToString();

            DataTableLoading();
        }

        private void KhachHang_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = KhachHang_SLUE.EditValue;

            KhachHang = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void PhongNghi_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = PhongNghi_SLUE.EditValue;

            PhongNghi = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void ThoiDiem_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = PaymentTimes.EditValue;

            ThoiDiem = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void TrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            DataTableLoading();
        }

        private void BangHoaDonPhong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangHoaDonPhongO.HitTest(e.X, e.Y);

                BangHoaDonPhongO.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangHoaDonPhongO.Rows[H.RowIndex].Selected = true;

                    BangTuyChonHoaDonPhong.ShowPopup(Cursor.Position);
                }
            }
        }

        Boolean Ascending = true;

        Int32 PreColumnIndex = -1;

        private void BangHoaDonPhongO_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String ColumnName = BangHoaDonPhongO.Columns[e.ColumnIndex].DataPropertyName;

            if (e.ColumnIndex != PreColumnIndex)
            {
                PreColumnIndex = e.ColumnIndex;

                Ascending = true;

                if (PreColumnIndex >= 0)
                {
                    BangHoaDonPhongO.Columns[PreColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }

            BangHoaDonPhongO.Tag = Ascending;

            List<HoaDonPhongCustom> GetSorted;

            if (String.IsNullOrEmpty(HoaDonSearch.Text.Trim()))
            {
                GetSorted = Ascending ? Save.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                           : Save.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                GetSorted = Ascending ? Filter.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                           : Filter.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }

            BangHoaDonPhongO.DataSource = new BindingList<HoaDonPhongCustom>(GetSorted);

            BangHoaDonPhongO.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = Ascending ? SortOrder.Ascending : SortOrder.Descending;

            Ascending = !Ascending;
        }
    }
}