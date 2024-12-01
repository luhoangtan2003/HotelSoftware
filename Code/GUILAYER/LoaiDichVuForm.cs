using DATALAYER;
using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class LoaiDichVuForm : DevExpress.XtraEditors.XtraForm
    {
        public LoaiDichVuForm()
        {
            HamChucNang.BangLoaiDV += DataLoading;

            InitializeComponent();
        }

        readonly LoaiDichVuBackend LoaiDVHandle = new LoaiDichVuBackend();

        public void DataLoading()
        {
            BangDuLieu.DataSource = LoaiDVHandle.LoadDataTable();

            BangDuLieu.ClearSelection();
        }

        private void LoaiDVForm_Load(object sender, EventArgs e)
        {
            DataLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinLoaiDichVu ThemLoai = new ThongTinLoaiDichVu(true);

            if (ThemLoai.ShowDialog() == DialogResult.OK)
            {
                LOAIDV_TBL LoadValue = ThemLoai.GetDataFromInfoForm();

                LoaiDVHandle.Add(LoadValue);

                DataLoading();

                HamChucNang.CapNhatBangDichVu();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinLoaiDichVu SuaLoai = new ThongTinLoaiDichVu(false);

            DataGridViewRow Row = BangDuLieu.SelectedRows[0];

            SuaLoai.FillDataForInfoForm(Row);

            if (SuaLoai.ShowDialog() == DialogResult.OK)
            {
                LOAIDV_TBL LoadValue = SuaLoai.GetDataFromInfoForm();

                LoaiDVHandle.Edit(LoadValue);

                DataLoading();

                HamChucNang.CapNhatBangDichVu();
            }
        }

        private void NutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

            String MaLoaiDichVu = GetRow.Cells["MALOAIDV"].Value.ToString();

            LoaiDVHandle.Remove(MaLoaiDichVu);

            DataLoading();

            HamChucNang.CapNhatBangDichVu();
        }

        private void BangDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (BangDuLieu.SelectedRows.Count > 0)
            {
                DataGridViewRow GetRow = BangDuLieu.SelectedRows[0];

                String MaLoaiDV = GetRow.Cells["MALOAIDV"].Value.ToString();

                if (LoaiDVHandle.Referenced(MaLoaiDV))
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