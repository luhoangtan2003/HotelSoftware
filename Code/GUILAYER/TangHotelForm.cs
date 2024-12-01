using DATALAYER;
using LOGICLAYER;
using System;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class TangHotelForm : DevExpress.XtraEditors.XtraForm
    {
        public TangHotelForm()
        {
            HamChucNang.BangTangHotel += DataLoading;

            InitializeComponent();
        }

        TangHotelBackend TangHotelHandle = new TangHotelBackend();

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinTangHotel ThemTang = new ThongTinTangHotel(true);

            if (ThemTang.ShowDialog() == DialogResult.OK)
            {
                TANGHOTEL_TBL Value = ThemTang.GetDataFromInfoForm();

                TangHotelHandle.Add(Value);

                DataLoading();

                HamChucNang.CapNhatBangPhong();
            }
        }

        private void DataLoading()
        {
            BangDuLieu.DataSource = TangHotelHandle.LoadDataTable();

            BangDuLieu.ClearSelection();
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinTangHotel SuaTang = new ThongTinTangHotel(false);

            DataGridViewRow Row = BangDuLieu.SelectedRows[0];

            SuaTang.FillDataForInfoForm(Row);

            if (SuaTang.ShowDialog() == DialogResult.OK)
            {
                TANGHOTEL_TBL Value = SuaTang.GetDataFromInfoForm();

                TangHotelHandle.Edit(Value);

                DataLoading();

                HamChucNang.CapNhatBangPhong();
            }
        }

        private void NutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataGridViewCellCollection GetRow = BangDuLieu.SelectedRows[0].Cells;

            Int32 MaSoTang = Convert.ToInt32(GetRow["TANGTHU"].Value.ToString());

            TangHotelHandle.Remove(MaSoTang);

            DataLoading();

            HamChucNang.CapNhatBangPhong();
        }

        private void BangDuLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (BangDuLieu.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection GetRow = BangDuLieu.SelectedRows[0].Cells;

                Int32 MaSoTang = Convert.ToInt32(GetRow["TANGTHU"].Value.ToString());

                if (TangHotelHandle.GetSoLuongPhong(MaSoTang, String.Empty) != 0)
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

        private void TangForm_Load(object sender, EventArgs e)
        {
            DataLoading();
        }
    }
}