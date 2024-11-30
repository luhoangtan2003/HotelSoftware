using DATALAYER;
using DevExpress.XtraBars.Alerter;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongTinDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinDatPhong()
        {
            InitializeComponent();
        }

        readonly LoaiHinhDPBackend LoaiHinhDPHandle = new();

        readonly PhongDatBackend PhongDatHandle = new();

        readonly KhachHangBackend KhachHandle = new();

        readonly TangHotelBackend TangHotelHandle = new();

        readonly LoaiPhongBackend LoaiPhongHandle = new();

        readonly PhongNghiBackend PhongNghiHandle = new();

        readonly HoaDonPhongBackend HoaDonPNHandle = new();

        readonly TinhTrangPhongBackend TinhTrangPNHandle = new();

        readonly TrangThaiPhongBackend TrangThaiPNHandle = new();

        List<PhongNghiCustom> Save;

        String LoaiPhong;

        Int32? TangHotel;

        String TinhTrang;

        String TrangThai;

        public void KhachHangDataLoading()
        {
            KhachHang_SLUE.Properties.DataSource = KhachHandle.LoadDataTable().ToList();
        }

        private void ThongTinPhongDat_Load(object sender, EventArgs e)
        {
            TinhTrangPN_SLUE.Properties.DataSource = TinhTrangPNHandle.LoadDataTable();

            TrangThaiPN_SLUE.Properties.DataSource = TrangThaiPNHandle.LoadDataTable();

            Tang_SLUE.Properties.DataSource = TangHotelHandle.LoadDataTable();

            Loai_SLUE.Properties.DataSource = LoaiPhongHandle.LoadDataTable();

            LoaiHinh_SLUE.Properties.DataSource = LoaiHinhDPHandle.LoadDataTable();

            SetDateTimeNow();

            Time.Start();

            KhachHangDataLoading();

            PhongNghiDataLoading();
        }

        private void Tang_SLUE_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = Tang_SLUE.EditValue;

            TangHotel = (Value != null) ? Convert.ToInt32(Value) : null;

            PhongNghiDataLoading();
        }

        private void Loai_SLUE_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = Loai_SLUE.EditValue;

            LoaiPhong = (Value != null) ? Value.ToString() : String.Empty;

            PhongNghiDataLoading();
        }

        private void TinhTrangPN_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TinhTrangPN_SLUE.EditValue;

            TinhTrang = (Value != null) ? Value.ToString() : String.Empty;

            PhongNghiDataLoading();
        }

        private void TrangThaiPN_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = TrangThaiPN_SLUE.EditValue;

            TrangThai = (Value != null) ? Value.ToString() : String.Empty;

            PhongNghiDataLoading();
        }

        private void PhongNghiSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String GetSearchText = PhongSearch.Text.Trim();

                Object Value = PhongNghiHandle.SearchPhong(GetSearchText);

                if (HamChucNang.IsFieldNull(Value))
                {
                    BangPhongOBanDau.DataSource = Save;
                }
                else
                {
                    BangPhongOBanDau.DataSource = Value;
                }
            }
        }

        private void NutThemKhachHang_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang ThemKhach = new ThongTinKhachHang(true);

            if (ThemKhach.ShowDialog() == DialogResult.OK)
            {
                KHACHHANG_TBL Value = ThemKhach.GetDataFromInfoForm();

                KhachHandle.Add(Value);

                KhachHangDataLoading();

                HamChucNang.CapNhatBangKhach();
            }
        }

        private void BangPhongOBanDau_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangPhongOBanDau.HitTest(e.X, e.Y);

                BangPhongOBanDau.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangPhongOBanDau.Rows[H.RowIndex].Selected = true;

                    DataGridViewRow SelectedRow = BangPhongOBanDau.SelectedRows[0];

                    Object MaTrangThai = SelectedRow.Cells["MATRANGTHAIPO"].Value;

                    if (MaTrangThai.ToString() == "SUSPENDED")
                    {
                        return;
                    }

                    BangPhongOBanDau.DoDragDrop(SelectedRow, DragDropEffects.Move);
                }
            }
        }

        private void BangPhongODaChon_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                DataGridViewRow Row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));

                Boolean CheckDataGridViewRow = Row.DataGridView.Columns.Contains("MAPHONGOBD");

                if (CheckDataGridViewRow)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void BangPhongODaChon_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewRow Row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));

            Boolean RowExists = false;

            Int32 ColumnToCheckA = BangPhongOBanDau.Columns["MAPHONGOBD"].Index;

            Int32 ColumnToCheckB = BangPhongODaChon.Columns["MAPHONGODC"].Index;

            foreach (DataGridViewRow R in BangPhongODaChon.Rows)
            {
                if (Equals(R.Cells[ColumnToCheckB].Value, Row.Cells[ColumnToCheckA].Value))
                {
                    RowExists = true;

                    break;
                }
            }

            if (RowExists == false)
            {
                Int32 RowIndex = BangPhongODaChon.Rows.Add();

                BangPhongODaChon.Rows[RowIndex].Cells["TENPHONGODC"].Value = Row.Cells["TENPHONGOBD"].Value;

                BangPhongODaChon.Rows[RowIndex].Cells["MAPHONGODC"].Value = Row.Cells["MAPHONGOBD"].Value;

                BangPhongODaChon.Rows[RowIndex].Cells["TIENTHEODDC"].Value = Row.Cells["TIENTHEODBD"].Value;

                BangPhongODaChon.Rows[RowIndex].Cells["TIENTHEOHDC"].Value = Row.Cells["TIENTHEOHBD"].Value;

                BangPhongODaChon.Rows[RowIndex].Cells["TENLOAIPHONGDC"].Value = Row.Cells["TENLOAIPHONGBD"].Value;

                SetTongGiaPhong();

                SoLuongPhongDat();
            }
        }

        private void BangPhongODaChon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo H = BangPhongODaChon.HitTest(e.X, e.Y);

                BangPhongODaChon.ClearSelection();

                if (H.RowIndex >= 0)
                {
                    BangPhongODaChon.Rows[H.RowIndex].Selected = true;

                    DataGridViewRow SelectedRow = BangPhongODaChon.SelectedRows[0];

                    BinForm Bin = new BinForm();

                    Bin.OnRowDroppedBangPhongO += HandleRowDeletion;

                    Bin.Show();

                    BangPhongODaChon.DoDragDrop(SelectedRow, DragDropEffects.Move);

                    Bin.OnRowDroppedBangPhongO -= HandleRowDeletion;

                    Bin.Close();
                }
            }
        }

        private void HandleRowDeletion(DataGridViewRow Row)
        {
            BangPhongODaChon.Rows.Remove(Row);

            SetTongGiaPhong();

            SoLuongPhongDat();
        }

        private void LoaiHinhDP_SLUE_EditValueChanged(object sender, EventArgs e)
        {
            Object Value = LoaiHinh_SLUE.EditValue;

            if (HamChucNang.IsFieldNull(Value))
            {
                BangPhongODaChon.Columns["TIENTHEOHDC"].Visible = false;

                BangPhongODaChon.Columns["TIENTHEODDC"].Visible = false;

                BangPhongOBanDau.Columns["TIENTHEOHBD"].Visible = false;

                BangPhongOBanDau.Columns["TIENTHEODBD"].Visible = false;
            }

            else

            if (Value.ToString() == "THEOH")
            {
                BangPhongODaChon.Columns["TIENTHEOHDC"].Visible = true;

                BangPhongODaChon.Columns["TIENTHEODDC"].Visible = false;

                BangPhongOBanDau.Columns["TIENTHEOHBD"].Visible = true;

                BangPhongOBanDau.Columns["TIENTHEODBD"].Visible = false;
            }

            else

            if (Value.ToString() == "THEOD")
            {
                BangPhongODaChon.Columns["TIENTHEOHDC"].Visible = false;

                BangPhongODaChon.Columns["TIENTHEODDC"].Visible = true;

                BangPhongOBanDau.Columns["TIENTHEOHBD"].Visible = false;

                BangPhongOBanDau.Columns["TIENTHEODBD"].Visible = true;
            }

            SetTongGiaPhong();

            SetHanDatPhong();
        }

        private void LoaiDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDateTimeNow();

            Boolean Allow = (LoaiDatPhong.EditValue.ToString() == "RESERVATION");

            if (Allow)
            {
                Time.Tick -= UpdateRealTime;

                NgayLay_DE.Enabled = Allow;

                NgayTra_DE.Enabled = Allow;

                GioLay_TE.Enabled = Allow;

                GioTra_TE.Enabled = Allow;
            }
            else
            {
                Time.Tick += UpdateRealTime;

                NgayLay_DE.Enabled = Allow;

                GioLay_TE.Enabled = Allow;

                NgayTra_DE.Enabled = !Allow;

                GioTra_TE.Enabled = !Allow;
            }
        }

        public void SetTongGiaPhong()
        {
            Object Value = LoaiHinh_SLUE.EditValue;

            String Type = (Value != null) ? Value.ToString() : String.Empty;

            Int32 Total = 0;

            switch (Type)
            {
                case "THEOD":

                    foreach (DataGridViewRow Row in BangPhongODaChon.Rows)
                    {
                        Object PhiObject = Row.Cells["TIENTHEODDC"].Value;

                        Total += Convert.ToInt32(PhiObject);
                    }

                    TongGiaPhongO.EditValue = Total;

                    break;

                case "THEOH":

                    foreach (DataGridViewRow Row in BangPhongODaChon.Rows)
                    {
                        Object PhiObject = Row.Cells["TIENTHEOHDC"].Value;

                        Total += Convert.ToInt32(PhiObject);
                    }

                    TongGiaPhongO.EditValue = Total;

                    break;

                case "":

                    TongGiaPhongO.EditValue = Total;

                    break;
            }
        }

        public void SetHanDatPhong()
        {
            if (DateTime.Compare(ThoiDiemLayPhong, ThoiDiemTraPhong) < 0)
            {
                TimeSpan Distance = ThoiDiemTraPhong - ThoiDiemLayPhong;

                SoNgay_SE.Value = Distance.Days;

                SoGio_SE.Value = Distance.Hours;

                SoPhut_SE.Value = Distance.Minutes;

                if (HamChucNang.IsFieldNull(LoaiHinh_SLUE.EditValue))
                {
                    ThoiHanPhongO.Value = 0;

                    DonViTinh_LC.Text = "!";
                }
                else
                {
                    if (LoaiHinh_SLUE.EditValue.ToString() == "THEOH" && SoNgay_SE.Value == 0)
                    {
                        ThoiHanPhongO.EditValue = Math.Round((Decimal)Distance.TotalHours, 2);

                        DonViTinh_LC.Text = "(H)";
                    }

                    else

                    if (LoaiHinh_SLUE.EditValue.ToString() == "THEOD" && SoNgay_SE.Value != 0)
                    {
                        ThoiHanPhongO.EditValue = Math.Round((Decimal)Distance.TotalDays, 2);

                        DonViTinh_LC.Text = "(D)";
                    }
                    else
                    {
                        ThoiHanPhongO.Value = 0;

                        DonViTinh_LC.Text = "!";
                    }
                }
            }
            else
            {
                ThoiHanPhongO.Value = SoNgay_SE.Value = SoGio_SE.Value = SoPhut_SE.Value = 0;
            }
        }

        DateTime ThoiDiemLayPhong;

        DateTime ThoiDiemTraPhong;

        public void UpdateRealTime(object sender, EventArgs e)
        {
            NgayLay_DE.EditValue = DateTime.Now;

            GioLay_TE.EditValue = DateTime.Now;
        }

        public void SetDateTimeNow()
        {
            NgayLay_DE.EditValue = DateTime.Now;

            NgayTra_DE.EditValue = DateTime.Now;

            GioLay_TE.EditValue = DateTime.Now;

            GioTra_TE.EditValue = DateTime.Now;
        }

        public DateTime FormatDateTime(DateTime GetDate)
        {
            return new DateTime(GetDate.Year, GetDate.Month, GetDate.Day, GetDate.Hour, GetDate.Minute, 0);
        }

        public void SetThoiDiemLay()
        {
            DateTime DateValue = NgayLay_DE.DateTime.Date;

            TimeSpan TimeValue = GioLay_TE.Time.TimeOfDay;

            DateTime FullDate = DateValue.Add(TimeValue);

            ThoiDiemLayPhong = FormatDateTime(FullDate);
        }

        public void SetThoiDiemTra()
        {
            DateTime DateValue = NgayTra_DE.DateTime.Date;

            TimeSpan TimeValue = GioTra_TE.Time.TimeOfDay;

            DateTime FullDate = DateValue.Add(TimeValue);

            ThoiDiemTraPhong = FormatDateTime(FullDate);
        }

        private void NgayLay_DE_EditValueChanged(object sender, EventArgs e)
        {
            SetThoiDiemLay();

            SetHanDatPhong();
        }

        private void NgayTra_DE_EditValueChanged(object sender, EventArgs e)
        {
            SetThoiDiemTra();

            SetHanDatPhong();
        }

        private void GioLay_TE_EditValueChanged(object sender, EventArgs e)
        {
            SetThoiDiemLay();

            SetHanDatPhong();
        }

        private void GioTra_TE_EditValueChanged(object sender, EventArgs e)
        {
            SetThoiDiemTra();

            SetHanDatPhong();
        }

        public void SoLuongPhongDat()

                        => SoLuongPhongO.EditValue = BangPhongODaChon.Rows.Count;

        private void ThoiHanPhongO_EditValueChanged(object sender, EventArgs e)
        {
            TienThanhToan.EditValue = TongGiaPhongO.Value * ThoiHanPhongO.Value;
        }

        private void TongGiaPhongO_EditValueChanged(object sender, EventArgs e)
        {
            TienThanhToan.EditValue = TongGiaPhongO.Value * ThoiHanPhongO.Value;
        }

        private void TienThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            TongThanhToan.Value = TienThanhToan.Value - (TienThanhToan.Value * (GiamGia.Value / 100));
        }

        private void GiamGiaPhong_EditValueChanged(object sender, EventArgs e)
        {
            if (GiamGia.Value > 100)
            {
                GiamGia.Value = 100;
            }
            if (GiamGia.Value < 0)
            {
                GiamGia.Value = 0;
            }

            TongThanhToan.Value = TienThanhToan.Value - (TienThanhToan.Value * (GiamGia.Value / 100));
        }

        public Boolean DataConstraintsAndValidity()
        {
            if (HamChucNang.IsFieldNull(KhachHang_SLUE.EditValue))
            {
                HamChucNang.ShowError("Mã khách thì không hợp lệ");

                return false;
            }

            if (HamChucNang.IsFieldNull(LoaiHinh_SLUE.EditValue))
            {
                HamChucNang.ShowError("Loại hình không hợp lệ");

                return false;
            }

            if (ThoiDiemLayPhong < FormatDateTime(DateTime.Now))
            {
                HamChucNang.ShowError("Ngày lấy không phù hợp");

                return false;
            }

            if (ThoiHanPhongO.Value <= 0)
            {
                HamChucNang.ShowError("Thời hạn thì không hợp lệ");

                return false;
            }
            else
            {
                if (LoaiHinh_SLUE.EditValue.ToString() == "THEOH")
                {
                    if (ThoiHanPhongO.Value < 03)
                    {
                        HamChucNang.ShowError("Hạn đặt >= 03 giờ");

                        return false;
                    }

                    if (ThoiHanPhongO.Value > 15)
                    {
                        HamChucNang.ShowError("Hạn đặt <= 15 giờ");

                        return false;
                    }
                }
                else
                {
                    if (ThoiHanPhongO.Value < 01)
                    {
                        HamChucNang.ShowError("Hạn đặt >= 1 ngày");

                        return false;
                    }

                    if (ThoiHanPhongO.Value > 07)
                    {
                        HamChucNang.ShowError("Hạn đặt <= 7 ngày");

                        return false;
                    }
                }
            }

            if (SoLuongPhongO.Value == 0)
            {
                HamChucNang.ShowError("Không có phòng nào được chọn");

                return false;
            }

            return true;
        }

        private void NutDatPhong_Click(object sender, EventArgs e)
        {
            if (DataConstraintsAndValidity() == false) { return; }

            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow PhongNghi in BangPhongODaChon.Rows)
            {
                PHONGDAT_TBL NewRow = new PHONGDAT_TBL();

                DataGridViewCell KeyCol = PhongNghi.Cells["MAPHONGODC"];

                NewRow.MAPHONG = KeyCol.Value.ToString();

                String MaKhachHang = KhachHang_SLUE.EditValue.ToString();

                NewRow.IDKHACH = MaKhachHang;

                NewRow.NGAYDAT = FormatDateTime(DateTime.Now);

                NewRow.THOIHAN = ThoiHanPhongO.Value;

                NewRow.GHICHU = ChuThich.Text.Trim();

                NewRow.NGAYLAY = ThoiDiemLayPhong;

                NewRow.NGAYTRA = ThoiDiemTraPhong;

                NewRow.MALOAIHINH = LoaiHinh_SLUE.EditValue.ToString();

                if (LoaiDatPhong.EditValue.ToString() == "RESERVATION")
                {
                    NewRow.MATRANGTHAI = "RESERVED";
                }
                else
                {
                    NewRow.MATRANGTHAI = "CHECKEDIN";
                }

                String NumOfBooked = PhongDatHandle.NumReserved(MaKhachHang).ToString("D5");

                NewRow.MAPHONGDAT = $"K{MaKhachHang}N{NumOfBooked}";

                Int32 GiaPhongBanDau;

                if (LoaiHinh_SLUE.EditValue.ToString() == "THEOH")
                {
                    GiaPhongBanDau = Convert.ToInt32(PhongNghi.Cells["TIENTHEOHDC"].Value);
                }
                else
                {
                    GiaPhongBanDau = Convert.ToInt32(PhongNghi.Cells["TIENTHEODDC"].Value);
                }

                NewRow.GIAPHONG = Convert.ToInt32(GiaPhongBanDau * ThoiHanPhongO.Value);

                AlertInfo SetInfo;

                List<DatPhongOCustom> Conflict = PhongDatHandle.Conflict(NewRow.MAPHONG, ThoiDiemLayPhong, ThoiDiemTraPhong);

                if (!HamChucNang.IsFieldNull(Conflict) && Conflict.Any())
                {
                    String Message = $"LỊCH ĐƯỢC ĐẶT CỦA PHÒNG {NewRow.MAPHONG} XUNG ĐỘT VỚI CÁC LỊCH ĐÃ LÊN LỊCH TRƯỚC ĐÓ";

                    SetInfo = new AlertInfo("THÔNG BÁO", Message, Properties.Resources.Conflict);

                    ThongBaoDatPhong.Show(Owner, SetInfo);

                    continue;
                }

                PhongDatHandle.Add(NewRow);

                if (LoaiDatPhong.EditValue.ToString() == "RESERVATION")
                {
                    PhongNghiHandle.Status(NewRow.MAPHONG, "RESERVED");
                }
                else
                {
                    PhongNghiHandle.Status(NewRow.MAPHONG, "OCCUPIED");
                }

                if (ThongBaoDichVu.EditValue.ToString() == "GMAILBOX")
                {
                    if (LoaiDatPhong.EditValue == (Object)"RESERVATION")
                    {
                        Boolean Yes = PhongDatHandle.Notice(NewRow.MAPHONGDAT, "RESERVED");
                    }
                    else
                    {
                        Boolean Yes = PhongDatHandle.Notice(NewRow.MAPHONGDAT, "OCCUPIED");
                    }
                }

                HOADONPHONG_TBL HD = new HOADONPHONG_TBL();

                // Mã hóa đơn trùng với mã đặt phòng vì code được thiết kế để cho chúng quan hệ 1 - 1

                HD.MAPHONGDAT = NewRow.MAPHONGDAT;

                HD.GIATRIBANDAU = NewRow.GIAPHONG;

                HD.GIAMGIA = ((int)GiamGia.Value);

                HD.MAHOADON = NewRow.MAPHONGDAT;

                HD.GIATHANHTOAN = HD.GIATRIBANDAU - ((Int32)(HD.GIATRIBANDAU * (GiamGia.Value / 100)));

                if (TimeOfPayment.EditValue.ToString() == "PAYLATER")
                {
                    HD.MATHOIDIEM = "PAYLATER";
                }
                else
                {
                    HD.MATHOIDIEM = "PAYNOW";
                }

                if (LoaiDatPhong.EditValue.ToString() != "IMMEDIATE")
                {
                    HD.MATRANGTHAI = "UNPAID";

                    HD.NGAYTHANHTOAN = (HD.MATHOIDIEM == "PAYLATER") ? NewRow.NGAYTRA : NewRow.NGAYLAY;
                }
                else
                {
                    if (HD.MATHOIDIEM != "PAYNOW")
                    {
                        HD.MATRANGTHAI = "UNPAID";

                        HD.NGAYTHANHTOAN = NewRow.NGAYTRA;
                    }
                    else
                    {
                        HD.MATRANGTHAI = "PAID";

                        HD.NGAYTHANHTOAN = NewRow.NGAYLAY;
                    }
                }

                HoaDonPNHandle.Add(HD);
            }

            HamChucNang.CapNhatBangHoaDonPhong();

            HamChucNang.CapNhatBookPhong();

            HamChucNang.CapNhatBangPhong();

            HamChucNang.CapNhatCheckInOut();

            HamChucNang.CapNhatBangThongKe();

            Cursor.Current = Cursors.Default;

            Close();
        }

        public void PhongNghiDataLoading()
        {
            Save = PhongNghiHandle.LoadDataTable(TangHotel, LoaiPhong, TinhTrang, TrangThai);

            BangPhongOBanDau.DataSource = Save;
        }

        private void NutHuyBo_Click(object sender, EventArgs e)
        {
            if (HamChucNang.ShowAlert("Bạn muốn thoát và hủy đặt phòng?") == DialogResult.OK)
            {
                Dispose();
            }
        }

        private void DinhDangKhungThongBao_BeforeFormShow(object sender, AlertFormEventArgs e)

                                                     => e.AlertForm.Size = new Size(450, 150);
    }
}