using DATALAYER;
using LOGICLAYER;
using System;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class LoaiPhongNghiForm : DevExpress.XtraEditors.XtraForm
    {
        public LoaiPhongNghiForm()
        {
            HamChucNang.BangLoaiPhong += DataLoading;

            InitializeComponent();
        }

        LoaiPhongBackend LoaiPhongHandle = new LoaiPhongBackend();

        private void DataLoading()
        {
            BangDuLieu.DataSource = LoaiPhongHandle.LoadDataTable();

            BangDuLieu.ClearSelection();
        }

        private void LoaiPhongForm_Load(object sender, EventArgs e)
        {
            DataLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinLoaiPhong ThemLoai = new ThongTinLoaiPhong(true);

            if (ThemLoai.ShowDialog() == DialogResult.OK)
            {
                LOAIPHONG_TBL Value = ThemLoai.GetDataFromInfoForm();

                LoaiPhongHandle.Add(Value);

                DataLoading();

                HamChucNang.CapNhatBangPhong();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinLoaiPhong SuaLoai = new ThongTinLoaiPhong(false);

            DataGridViewRow Row = BangDuLieu.SelectedRows[0];

            SuaLoai.FillDataForInfoForm(Row);

            if (SuaLoai.ShowDialog() == DialogResult.OK)
            {
                LOAIPHONG_TBL Value = SuaLoai.GetDataFromInfoForm();

                LoaiPhongHandle.Edit(Value);

                DataLoading();

                HamChucNang.CapNhatBangPhong();

                HamChucNang.CapNhatBookPhong();
            }
        }

        private void NutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

            String MaLoaiPhong = GetRow.Cells["MALOAIPHONG"].Value.ToString();

            LoaiPhongHandle.Remove(MaLoaiPhong);

            DataLoading();

            HamChucNang.CapNhatBangPhong();
        }

        private void BangDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (BangDuLieu.SelectedRows.Count > 0)
            {
                DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

                String MaLoai = GetRow.Cells["MALOAIPHONG"].Value.ToString();

                if (LoaiPhongHandle.Referenced(MaLoai))
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
    }
}