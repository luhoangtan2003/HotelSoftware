using DATALAYER;
using LOGICLAYER;
using System;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinTangHotel : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinTangHotel(Boolean AllowAdds)
        {
            InitializeComponent();

            AddOnMode = AllowAdds;

            MaSoTang.Enabled = AllowAdds;
        }

        readonly Boolean AddOnMode;

        readonly TangHotelBackend TangHotelHandle = new TangHotelBackend();

        public void FillDataForInfoForm(DataGridViewRow Row)
        {
            MaSoTang.EditValue = Row.Cells["TANGTHU"].Value;

            TenTangKS.EditValue = Row.Cells["TENTANG"].Value;
        }

        public TANGHOTEL_TBL GetDataFromInfoForm()
        {
            TANGHOTEL_TBL NewRow = new();

            NewRow.TANGTHU = ((int)MaSoTang.Value);

            NewRow.TENTANG = TenTangKS.Text.Trim();

            return NewRow;
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (HamChucNang.IsFieldNull(MaSoTang.EditValue))
            {
                HamChucNang.ShowError("Trường này thì rỗng");

                return;
            }

            if (MaSoTang.Value < 0)
            {
                HamChucNang.ShowError("Giá trị không hợp lệ");

                return;
            }

            if (AddOnMode == true)
            {
                if (TangHotelHandle.Duplicate(((int)MaSoTang.Value)))
                {
                    HamChucNang.ShowError("Mã số tầng này đã có rồi");

                    return;
                }
            }

            if (String.IsNullOrEmpty(TenTangKS.Text.Trim()))
            {
                HamChucNang.ShowError("Tên tầng đang rỗng");

                return;
            }

            NutOK.DialogResult = DialogResult.OK;

            HamChucNang.LockForm(NutHuy, NutOK);
        }
    }
}