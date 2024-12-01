using DATALAYER;
using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinLoaiDichVu : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinLoaiDichVu(Boolean AllowAdds)
        {
            InitializeComponent();

            AddOnMode = AllowAdds;

            MaSoLoaiDV.Enabled = AllowAdds;
        }

        readonly Boolean AddOnMode;

        readonly LoaiDichVuBackend LoaiDVHandle = new LoaiDichVuBackend();

        public void FillDataForInfoForm(DataGridViewRow Row)
        {
            MaSoLoaiDV.EditValue = Row.Cells["MALOAIDV"].Value;

            TenLoaiDV.EditValue = Row.Cells["TENLOAIDV"].Value;

            MoTaDV.EditValue = Row.Cells["MOTA"].Value;
        }

        public LOAIDV_TBL GetDataFromInfoForm()
        {
            LOAIDV_TBL NewRow = new();

            NewRow.MALOAIDV = MaSoLoaiDV.Text.Trim();

            NewRow.TENLOAIDV = TenLoaiDV.Text.Trim();

            NewRow.MOTA = MoTaDV.Text.Trim();

            return NewRow;
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaSoLoaiDV.Text.Trim()))
            {
                HamChucNang.ShowError("Mã số không hợp lệ");

                return;
            }

            if (AddOnMode)
            {
                if (LoaiDVHandle.Duplicate(MaSoLoaiDV.Text.Trim()))
                {
                    HamChucNang.ShowError("Mã loại dịch vụ đã có");

                    return;
                }
            }

            if (String.IsNullOrEmpty(TenLoaiDV.Text.Trim()))
            {
                HamChucNang.ShowError("Tên loại này không hợp lệ");

                return;
            }

            NutOK.DialogResult = DialogResult.OK;

            HamChucNang.LockForm(NutHuy, NutOK);
        }
    }
}