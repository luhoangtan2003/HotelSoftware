using DATALAYER;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class DichVuYeuCauForm : DevExpress.XtraEditors.XtraForm
    {
        public DichVuYeuCauForm()
        {
            HamChucNang.BangDichVu += DataLoading;

            InitializeComponent();
        }

        readonly LoaiHinhDVBackend LoaiHinhDVHandle = new();

        readonly LoaiDichVuBackend LoaiDVHandle = new();

        readonly DichVuBackend DichVuHandle = new();

        readonly TrangThaiDVBackend TrangThaiHandle = new();

        List<DichVuCustom> Save, Filter;

        String TrangThai;

        String LoaiHinh;

        String LoaiDichVu;

        public void DataLoading()
        {
            LoaiDichVu_SLUE.Properties.DataSource = LoaiDVHandle.LoadDataTable();

            TableLoading();
        }

        public void TableLoading()
        {
            Save = DichVuHandle.LoadDataTable(LoaiDichVu, LoaiHinh, TrangThai);

            BangDuLieu.DataSource = Save;

            BangDuLieu.ClearSelection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TrangThai_SLUE.Properties.DataSource = TrangThaiHandle.LoadDataTable();

            LoaiHinh_SLUE.Properties.DataSource = LoaiHinhDVHandle.LoadDataTable();

            DataLoading();
        }

        private void LoaiHinh_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = LoaiHinh_SLUE.EditValue;

            LoaiHinh = (Value != null) ? Value.ToString() : String.Empty;

            TableLoading();
        }

        private void TrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            TableLoading();
        }

        private void LoaiDichVu_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = LoaiDichVu_SLUE.EditValue;

            LoaiDichVu = (Value != null) ? Value.ToString() : String.Empty;

            TableLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinDichVuKS ThemDichVu = new ThongTinDichVuKS(true);

            if (ThemDichVu.ShowDialog() == DialogResult.OK)
            {
                DICHVU_TBL Value = ThemDichVu.GetDataFromInfoForm();

                DichVuHandle.Add(Value);

                TableLoading();

                HamChucNang.CapNhatBangLoaiDV();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinDichVuKS SuaDichVu = new ThongTinDichVuKS(false);

            DataGridViewRow Focus = BangDuLieu.SelectedRows[0];

            SuaDichVu.FillDataForInfoForm(Focus);

            if (SuaDichVu.ShowDialog() == DialogResult.OK)
            {
                DICHVU_TBL Value = SuaDichVu.GetDataFromInfoForm();

                DichVuHandle.Edit(Value);

                TableLoading();

                HamChucNang.CapNhatBangLoaiDV();
            }
        }

        private void NutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String GetMaDichVu = BangDuLieu.SelectedRows[0].Cells["MADICHVU"].Value.ToString();

            DichVuHandle.Remove(GetMaDichVu);

            TableLoading();

            HamChucNang.CapNhatBangLoaiDV();
        }

        private void BangDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (BangDuLieu.SelectedRows.Count > 0)
            {
                DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

                String MaDichVu = GetRow.Cells["MADICHVU"].Value.ToString();

                if (DichVuHandle.Referenced(MaDichVu))
                {
                    NutXoa.Enabled = false;
                }
                else
                {
                    NutXoa.Enabled = true;
                }

                NutSua.Enabled = true;
            }
            else
            {
                NutXoa.Enabled = false;

                NutSua.Enabled = false;
            }
        }

        private void DichVuSearch_TextChanged(object sender, EventArgs e)
        {
            Lock.Stop(); Lock.Start();
        }

        private void DichVuSearchAfterTyping(object sender, EventArgs e)
        {
            Lock.Stop();

            String Text = DichVuSearch.Text.Trim();

            List<DichVuCustom> Value = DichVuHandle.SearchDichVu(Text);

            if (HamChucNang.IsFieldNull(Value))
            {
                BangDuLieu.DataSource = Save;
            }
            else
            {
                BangDuLieu.DataSource = Value;

                Filter = Value;
            }
        }

        Boolean Ascending = true;

        Int32 PreColumnIndex = -1;

        private void BangDuLieu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String ColumnName = BangDuLieu.Columns[e.ColumnIndex].DataPropertyName;

            if (e.ColumnIndex != PreColumnIndex)
            {
                PreColumnIndex = e.ColumnIndex;

                Ascending = true;

                if (PreColumnIndex >= 0)
                {
                    BangDuLieu.Columns[PreColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }

            BangDuLieu.Tag = Ascending;

            List<DichVuCustom> Sorted;

            if (String.IsNullOrEmpty(DichVuSearch.Text.Trim()))
            {
                Sorted = Ascending ? Save.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                        : Save.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                Sorted = Ascending ? Filter.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                        : Filter.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }

            BangDuLieu.DataSource = new BindingList<DichVuCustom>(Sorted);

            BangDuLieu.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = Ascending ? SortOrder.Ascending : SortOrder.Descending;

            Ascending = !Ascending;
        }
    }
}