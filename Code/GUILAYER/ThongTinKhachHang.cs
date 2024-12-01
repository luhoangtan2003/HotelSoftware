using DATALAYER;
using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinKhachHang(Boolean AllowAdds)
        {
            InitializeComponent();

            AddOnMode = AllowAdds;

            IDKhach.Enabled = AllowAdds;
        }

        readonly Boolean AddOnMode;

        readonly QuocTichBackend QuocTichHandle = new QuocTichBackend();

        readonly GioiTinhBackend GioiTinhHandle = new GioiTinhBackend();

        readonly KhachHangBackend KhachHandle = new KhachHangBackend();

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            GioiTinh_SLUE.Properties.DataSource = GioiTinhHandle.LoadDataTable();

            QuocTich_SLUE.Properties.DataSource = QuocTichHandle.LoadDataTable();
        }

        public void FillDataForInfoForm(DataGridViewRow Row)
        {
            IDKhach.EditValue = Row.Cells["IDKHACH"].Value;

            HoVaTen.EditValue = Row.Cells["HOVATEN"].Value;

            GioiTinh_SLUE.EditValue = Row.Cells["MAGT"].Value;

            QuocTich_SLUE.EditValue = Row.Cells["MAQT"].Value;

            SoLienHe.EditValue = Row.Cells["SOLIENHE"].Value;

            Email.EditValue = Row.Cells["EMAIL"].Value;

            QueQuan.Text = Row.Cells["QUEQUAN"].Value.ToString();
        }

        public KHACHHANG_TBL GetDataFromInfoForm()
        {
            KHACHHANG_TBL KhachHang = new();

            KhachHang.IDKHACH = IDKhach.Text.Trim();

            KhachHang.HOVATEN = HoVaTen.Text.Trim();

            KhachHang.MAGT = GioiTinh_SLUE.EditValue.ToString();

            KhachHang.MAQT = QuocTich_SLUE.EditValue.ToString();

            KhachHang.SOLIENHE = SoLienHe.Text.Trim();

            KhachHang.EMAIL = Email.Text.Trim();

            KhachHang.QUEQUAN = QueQuan.Text.Trim();

            return KhachHang;
        }

        private void NutOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDKhach.Text.Trim()))
            {
                HamChucNang.ShowError("Mã số không hợp lệ");

                return;
            }

            if (AddOnMode)
            {
                if (KhachHandle.Duplicate(IDKhach.Text.Trim()))
                {
                    HamChucNang.ShowError("Mã này đã tồn tại");

                    return;
                }
            }

            if (String.IsNullOrEmpty(HoVaTen.Text.Trim()))
            {
                HamChucNang.ShowError("Họ tên không hợp lệ");

                return;
            }

            if (HamChucNang.IsFieldNull(GioiTinh_SLUE.EditValue))
            {
                HamChucNang.ShowError("Giới tính hiện đang rỗng");

                return;
            }

            if (HamChucNang.IsFieldNull(QuocTich_SLUE.EditValue))
            {
                HamChucNang.ShowError("Quốc tịch hiện đang rỗng");

                return;
            }

            NutOK.DialogResult = DialogResult.OK;

            HamChucNang.LockForm(NutHuy, NutOK);
        }
    }
}