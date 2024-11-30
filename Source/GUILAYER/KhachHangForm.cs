using DATALAYER;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class KhachHangForm : DevExpress.XtraEditors.XtraForm
    {
        public KhachHangForm()
        {
            HamChucNang.BangKhach += DataLoading;

            InitializeComponent();
        }

        QuocTichBackend QuocTichHandle = new QuocTichBackend();

        GioiTinhBackend GioiTinhHandle = new GioiTinhBackend();

        KhachHangBackend KhachHandle = new KhachHangBackend();

        String GioiTinh;

        String QuocTich;

        List<KhachHangCustom> Save, Filter;

        public void DataLoading()
        {
            Save = KhachHandle.LoadDataTable(GioiTinh, QuocTich);

            BangDuLieu.DataSource = Save;

            BangDuLieu.ClearSelection();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            GioiTinh_SLUE.Properties.DataSource = GioiTinhHandle.LoadDataTable();

            QuocTich_SLUE.Properties.DataSource = QuocTichHandle.LoadDataTable();

            DataLoading();
        }

        private void GioiTinh_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = GioiTinh_SLUE.EditValue;

            GioiTinh = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void QuocTich_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = QuocTich_SLUE.EditValue;

            QuocTich = (Value != null) ? Value.ToString() : String.Empty;

            DataLoading();
        }

        private void NutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinKhachHang ThemKhach = new ThongTinKhachHang(true);

            if (ThemKhach.ShowDialog() == DialogResult.OK)
            {
                KHACHHANG_TBL Value = ThemKhach.GetDataFromInfoForm();

                KhachHandle.Add(Value);

                HamChucNang.CapNhatBangKhach();
            }
        }

        private void NutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinKhachHang SuaKhach = new ThongTinKhachHang(false);

            SuaKhach.FillDataForInfoForm(BangDuLieu.SelectedRows[0]);

            if (SuaKhach.ShowDialog() == DialogResult.OK)
            {
                KHACHHANG_TBL Value = SuaKhach.GetDataFromInfoForm();

                KhachHandle.Edit(Value);

                HamChucNang.CapNhatBangKhach();
            }
        }

        private void BangDuLieu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangDuLieu.HitTest(e.X, e.Y);

                BangDuLieu.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangDuLieu.Rows[H.RowIndex].Selected = true;

                    BangTuyChonKhach.ShowPopup(Cursor.Position);
                }
            }
        }

        private void KhachSearch_TextChanged(object sender, EventArgs e)
        {
            Lock.Stop(); Lock.Start();
        }

        Boolean Ascending = true;

        Int32 PreColumnIndex = -1;

        private void KhachSearchAfterTyping(object sender, EventArgs e)
        {
            Lock.Stop();

            String Text = KhachSearch.Text.Trim();

            List<KhachHangCustom> Value = KhachHandle.SearchKhach(Text);

            if (HamChucNang.IsFieldNull(Value))
            {
                BangDuLieu.DataSource = Save;
            }
            else
            {
                BangDuLieu.DataSource = Value;

                Filter = Value;
            }
        }

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

            List<KhachHangCustom> List;

            if (String.IsNullOrEmpty(KhachSearch.Text.Trim()))
            {
                List = Ascending ? Save.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                      : Save.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                List = Ascending ? Filter.OrderBy(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList()

                      : Filter.OrderByDescending(x => x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }

            BangDuLieu.DataSource = new BindingList<KhachHangCustom>(List);

            BangDuLieu.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = Ascending ? SortOrder.Ascending : SortOrder.Descending;

            Ascending = !Ascending;
        }
    }
}