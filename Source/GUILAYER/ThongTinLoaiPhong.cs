using DATALAYER;
using LOGICLAYER;
using System;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinLoaiPhong(Boolean AllowAdds)
        {
            InitializeComponent();

            AddOnMode = AllowAdds;

            MaSoLoai.Enabled = AllowAdds;
        }

        readonly Boolean AddOnMode;

        readonly LoaiPhongBackend LoaiPhongHandle = new LoaiPhongBackend();

        public void FillDataForInfoForm(DataGridViewRow Row)
        {
            MaSoLoai.EditValue = Row.Cells["MALOAIPHONG"].Value;

            TenLoai.EditValue = Row.Cells["TENLOAIPHONG"].Value;

            SucChua.EditValue = Row.Cells["SUCCHUA"].Value;

            MoTa.Text = Row.Cells["MOTA"].Value.ToString();

            Giuong.EditValue = Row.Cells["SOGIUONG"].Value;

            TienTrongNgay.EditValue = Row.Cells["TIENTHEOH"].Value;

            TienNgoaiNgay.EditValue = Row.Cells["TIENTHEOD"].Value;
        }

        public LOAIPHONG_TBL GetDataFromInfoForm()
        {
            LOAIPHONG_TBL NewRow = new();

            NewRow.MALOAIPHONG = MaSoLoai.Text.Trim();

            NewRow.TENLOAIPHONG = TenLoai.Text.Trim();

            NewRow.SUCCHUA = ((int)SucChua.Value);

            NewRow.MOTA = MoTa.Text.Trim();

            NewRow.SOGIUONG = ((int)Giuong.Value);

            NewRow.TIENTHEOD = ((int)TienNgoaiNgay.Value);

            NewRow.TIENTHEOH = ((int)TienTrongNgay.Value);

            return NewRow;
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaSoLoai.Text.Trim()))
            {
                HamChucNang.ShowError("Mã số không hợp lệ");

                return;
            }

            if (AddOnMode)
            {
                if (LoaiPhongHandle.Duplicate(MaSoLoai.Text.Trim()))
                {
                    HamChucNang.ShowError("Mã loại phòng này đã có");

                    return;
                }
            }

            if (String.IsNullOrEmpty(TenLoai.Text.Trim()))
            {
                HamChucNang.ShowError("Tên không hợp lệ");

                return;
            }

            if (HamChucNang.IsFieldNull(SucChua.EditValue))
            {
                HamChucNang.ShowError("Sức chứa đang rỗng");

                return;
            }

            if (SucChua.Value <= 0)
            {
                HamChucNang.ShowError("Sức chứa phải > 0");

                return;
            }

            if (HamChucNang.IsFieldNull(Giuong.EditValue))
            {
                HamChucNang.ShowError("Giường đang rỗng");

                return;
            }

            if (Giuong.Value <= 0)
            {
                HamChucNang.ShowError("Giường phải > 0");

                return;
            }

            if
            (HamChucNang.IsFieldNull(TienNgoaiNgay.EditValue)
            ||
            HamChucNang.IsFieldNull(TienTrongNgay.EditValue))
            {
                HamChucNang.ShowError("Giá tiền đang rỗng");

                return;
            }

            if
            (TienNgoaiNgay.Value <= 0
            ||
            TienTrongNgay.Value <= 0)
            {
                HamChucNang.ShowError("Giá tiền phải > 0");

                return;
            }

            NutOK.DialogResult = DialogResult.OK;

            HamChucNang.LockForm(NutHuy, NutOK);
        }
    }
}