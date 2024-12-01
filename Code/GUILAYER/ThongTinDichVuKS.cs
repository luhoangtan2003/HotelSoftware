using DATALAYER;
using LOGICLAYER;
using System;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinDichVuKS : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinDichVuKS(Boolean AllowAdds)
        {
            InitializeComponent();

            AddOnMode = AllowAdds;

            MaSoDichVu.Enabled = AllowAdds;
        }

        readonly Boolean AddOnMode;

        readonly LoaiDichVuBackend LoaiDVHandle = new();

        readonly LoaiHinhDVBackend MoHinhHandle = new();

        readonly DichVuBackend DichVuHandle = new();

        readonly TrangThaiDVBackend TrangThaiHandle = new();

        public DICHVU_TBL GetDataFromInfoForm()
        {
            DICHVU_TBL NewRow = new DICHVU_TBL();

            NewRow.MOTA = MoTaDichVu.Text.Trim();

            NewRow.MADICHVU = MaSoDichVu.Text.Trim();

            NewRow.TENDICHVU = TenDichVu.Text.Trim();

            NewRow.MALOAIDV = LoaiDichVu.EditValue.ToString();

            NewRow.GIADICHVU = Convert.ToInt32(PhiDV.EditValue);

            NewRow.MALOAIHINH = LoaiHinhDV.EditValue.ToString();

            NewRow.MATRANGTHAI = TrangThai.EditValue.ToString();

            return NewRow;
        }

        public void FillDataForInfoForm(DataGridViewRow Row)
        {
            MaSoDichVu.EditValue = Row.Cells["MADICHVU"].Value;

            TenDichVu.EditValue = Row.Cells["TENDICHVU"].Value;

            PhiDV.EditValue = Row.Cells["GIADICHVU"].Value;

            LoaiDichVu.EditValue = Row.Cells["MALOAIDV"].Value;

            TrangThai.EditValue = Row.Cells["MATRANGTHAI"].Value;

            LoaiHinhDV.EditValue = Row.Cells["MALOAIHINH"].Value;

            MoTaDichVu.Text = Row.Cells["MOTA"].Value.ToString();
        }

        private void ThongTinDichVu_Load(object sender, EventArgs e)
        {
            LoaiDichVu.Properties.DataSource = LoaiDVHandle.LoadDataTable();

            LoaiHinhDV.Properties.DataSource = MoHinhHandle.LoadDataTable();

            TrangThai.Properties.DataSource = TrangThaiHandle.LoadDataTable();
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaSoDichVu.Text.Trim()))
            {
                HamChucNang.ShowError("Mã số không hợp lệ");

                return;
            }

            if (AddOnMode)
            {
                if (DichVuHandle.Duplicate(MaSoDichVu.Text.Trim()))
                {
                    HamChucNang.ShowError("Mã dịch vụ đã tồn tại");

                    return;
                }
            }

            if (String.IsNullOrEmpty(TenDichVu.Text.Trim()))
            {
                HamChucNang.ShowError("Tên dịch vụ không hợp lệ");

                return;
            }

            if (HamChucNang.IsFieldNull(PhiDV.EditValue))
            {
                HamChucNang.ShowError("Phí dịch vụ không hợp lệ");

                return;
            }

            if (PhiDV.Value < 0)
            {
                HamChucNang.ShowError("Phí dịch vụ không thể âm");

                return;
            }

            if (HamChucNang.IsFieldNull(LoaiDichVu.EditValue))
            {
                HamChucNang.ShowError("Loại dịch vụ không hợp lệ");

                return;
            }

            if (HamChucNang.IsFieldNull(LoaiHinhDV.EditValue))
            {
                HamChucNang.ShowError("Loại hình DV không hợp lệ");

                return;
            }

            if (HamChucNang.IsFieldNull(TrangThai.EditValue))
            {
                HamChucNang.ShowError("Trạng thái DV không hợp lệ");

                return;
            }

            NutOK.DialogResult = DialogResult.OK;

            HamChucNang.LockForm(NutHuy, NutOK);
        }
    }
}