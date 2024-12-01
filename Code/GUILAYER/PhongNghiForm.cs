using DATALAYER;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class PhongNghiForm : DevExpress.XtraEditors.XtraForm
    {
        public PhongNghiForm()
        {
            HamChucNang.BangPhong += RefreshData;

            InitializeComponent();
        }

        readonly TangHotelBackend TangHotelHandle = new();

        readonly LoaiPhongBackend LoaiPhongHandle = new();

        readonly PhongNghiBackend PhongNghiHandle = new();

        readonly TinhTrangPhongBackend TinhTrangHandle = new();

        readonly TrangThaiPhongBackend TrangThaiHandle = new();

        String LoaiPhong;

        Int32? TangHotel;

        String TinhTrang;

        String TrangThai;

        List<PhongNghiCustom> Save, Filter;

        public void RefreshData()
        {
            Tang_SLUE.Properties.DataSource = TangHotelHandle.LoadDataTable();

            Loai_SLUE.Properties.DataSource = LoaiPhongHandle.LoadDataTable();

            DataLoading();
        }

        private void PhongHotelForm_Load(object sender, EventArgs e)
        {
            TinhTrang_SLUE.Properties.DataSource = TinhTrangHandle.LoadDataTable();

            TrangThai_SLUE.Properties.DataSource = TrangThaiHandle.LoadDataTable();

            RefreshData();
        }

        private void Tang_SLUE_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = Tang_SLUE.EditValue;

            TangHotel = (Value != null) ? Convert.ToInt32(Value) : null;

            DataLoading();
        }

        private void LoaiPhong_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = Loai_SLUE.EditValue;

            LoaiPhong = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void TinhTrang_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TinhTrang_SLUE.EditValue;

            TinhTrang = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void TrangThai_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThai_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinPhongNghi ThemPhong = new ThongTinPhongNghi(true);

            if (ThemPhong.ShowDialog() == DialogResult.OK)
            {
                PHONGNGHI_TBL Value = ThemPhong.GetDataFromInfoForm();

                PhongNghiHandle.Add(Value);

                DataLoading();

                HamChucNang.CapNhatBangTangHotel();

                HamChucNang.CapNhatBangLoaiPhong();

                HamChucNang.CapNhatPhongDatPhong();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinPhongNghi ThemPhong = new ThongTinPhongNghi(false);

            DataGridViewRow Focus = BangDuLieu.SelectedRows[0];

            String GetTinhTrang = Focus.Cells["MATINHTRANG"].Value.ToString();

            String GetTrangThai = Focus.Cells["MATRANGTHAI"].Value.ToString();

            ThemPhong.FillDataForInfoForm(Focus);

            if (ThemPhong.ShowDialog() == DialogResult.OK)
            {
                PHONGNGHI_TBL Value = ThemPhong.GetDataFromInfoForm();

                if (GetTrangThai == "OCCUPIED" || GetTrangThai == "RESERVED")
                {
                    if (GetTinhTrang != Value.MATINHTRANG)
                    {
                        HamChucNang.ShowError("Phòng sắp hoặc đang có khách");

                        return;
                    }
                }

                PhongNghiHandle.Edit(Value);

                DataLoading();

                HamChucNang.CapNhatBangTangHotel();

                HamChucNang.CapNhatBangLoaiPhong();

                HamChucNang.CapNhatPhongDatPhong();
            }
        }

        private void NutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String GetMaSoPhong = BangDuLieu.SelectedRows[0].Cells["MAPHONG"].Value.ToString();

            PhongNghiHandle.Remove(GetMaSoPhong);

            DataLoading();

            HamChucNang.CapNhatBangTangHotel();

            HamChucNang.CapNhatBangLoaiPhong();

            HamChucNang.CapNhatPhongDatPhong();
        }

        public void DataLoading()
        {
            Save = PhongNghiHandle.LoadDataTable(TangHotel, LoaiPhong, TinhTrang, TrangThai);

            BangDuLieu.DataSource = Save;

            BangDuLieu.ClearSelection();
        }

        private void BangDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (BangDuLieu.SelectedRows.Count > 0)
            {
                DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

                String MaSoPhong = GetRow.Cells["MAPHONG"].Value.ToString();

                if (PhongNghiHandle.Referenced(MaSoPhong))
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

        private void PhongSearch_TextChanged(object sender, EventArgs e)
        {
            Lock.Stop(); Lock.Start();
        }

        private void PhongSearchAfterTyping(object sender, EventArgs e)
        {
            Lock.Stop();

            String GetSearchText = PhongSearch.Text.Trim();

            Object Value = PhongNghiHandle.SearchPhong(GetSearchText);

            if (HamChucNang.IsFieldNull(Value))
            {
                BangDuLieu.DataSource = Save;
            }
            else
            {
                BangDuLieu.DataSource = Value;

                Filter = Value as List<PhongNghiCustom>;
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

            List<PhongNghiCustom> List;

            if (String.IsNullOrEmpty(PhongSearch.Text.Trim()))
            {
                List = Ascending ? Save.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                      : Save.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                List = Ascending ? Filter.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                      : Filter.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }

            BangDuLieu.DataSource = new BindingList<PhongNghiCustom>(List);

            BangDuLieu.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = Ascending ? SortOrder.Ascending : SortOrder.Descending;

            Ascending = !Ascending;
        }
    }
}