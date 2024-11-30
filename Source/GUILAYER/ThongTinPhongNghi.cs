using DATALAYER;
using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinPhongNghi : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinPhongNghi(Boolean AllowAdds)
        {
            InitializeComponent();

            AddOnMode = AllowAdds;

            MaSoPhong.Enabled = AllowAdds;
        }

        readonly Boolean AddOnMode;

        readonly TangHotelBackend TangHotelHandle = new TangHotelBackend();

        readonly LoaiPhongBackend LoaiPhongHandle = new LoaiPhongBackend();

        readonly PhongNghiBackend PhongNghiHandle = new PhongNghiBackend();

        readonly TinhTrangPhongBackend TinhTrangHandle = new TinhTrangPhongBackend();

        readonly TrangThaiPhongBackend TrangThaiHandle = new TrangThaiPhongBackend();

        public PHONGNGHI_TBL GetDataFromInfoForm()
        {
            PHONGNGHI_TBL NewRow = new();

            NewRow.TANGTHU = Convert.ToInt32(Tang_SLUE.EditValue);

            NewRow.TENPHONG = TenPhong.Text.Trim();

            NewRow.MAPHONG = MaSoPhong.Text.Trim();

            NewRow.MALOAIPHONG = Loai_SLUE.EditValue.ToString();

            NewRow.MATINHTRANG = TinhTrang.EditValue.ToString();

            if (NewRow.MATINHTRANG == "ACTIVE")

                NewRow.MATRANGTHAI = "AVAILABLE";

            else

                NewRow.MATRANGTHAI = "SUSPENDED";

            return NewRow;
        }

        public void FillDataForInfoForm(DataGridViewRow Row)
        {
            MaSoPhong.Text = Row.Cells["MAPHONG"].Value.ToString();

            TenPhong.Text = Row.Cells["TENPHONG"].Value.ToString();

            Tang_SLUE.EditValue = Row.Cells["TANGTHU"].Value;

            Loai_SLUE.EditValue = Row.Cells["MALOAIPHONG"].Value;

            TinhTrang.EditValue = Row.Cells["MATINHTRANG"].Value;

            TrangThai.EditValue = Row.Cells["MATRANGTHAI"].Value;
        }

        private void ThemPhongForm_Load(object sender, EventArgs e)
        {
            Tang_SLUE.Properties.DataSource = TangHotelHandle.LoadDataTable();

            Loai_SLUE.Properties.DataSource = LoaiPhongHandle.LoadDataTable();

            TinhTrang.Properties.DataSource = TinhTrangHandle.LoadDataTable();

            TrangThai.Properties.DataSource = TrangThaiHandle.LoadDataTable();
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaSoPhong.Text.Trim()))
            {
                HamChucNang.ShowError("Mã số không hợp lệ");

                return;
            }

            if (AddOnMode)
            {
                if (PhongNghiHandle.Duplicate(MaSoPhong.Text.Trim()))
                {
                    HamChucNang.ShowError("Mã phòng này đã có rồi");

                    return;
                }
            }

            if (String.IsNullOrEmpty(TenPhong.Text.Trim()))
            {
                HamChucNang.ShowError("Tên phòng này không hợp lệ");

                return;
            }

            if (HamChucNang.IsFieldNull(Tang_SLUE.EditValue))
            {
                HamChucNang.ShowError("Tầng hiện đang rỗng");

                return;
            }

            if (HamChucNang.IsFieldNull(Loai_SLUE.EditValue))
            {
                HamChucNang.ShowError("Loại hiện đang rỗng");

                return;
            }

            if (HamChucNang.IsFieldNull(TinhTrang.EditValue))
            {
                HamChucNang.ShowError("Tình trạng đang rỗng");

                return;
            }

            NutOK.DialogResult = DialogResult.OK;

            HamChucNang.LockForm(NutHuy, NutOK);
        }
    }
}