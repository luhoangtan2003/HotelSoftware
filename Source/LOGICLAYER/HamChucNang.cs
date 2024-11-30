using System;
using System.Linq;
using System.Windows.Forms;

namespace LOGICLAYER
{
    public static class HamChucNang
    {
        public static event Action BangTangHotel;

        public static void CapNhatBangTangHotel()
        {
            BangTangHotel?.Invoke();
        }

        public static event Action BangLoaiPhong;

        public static void CapNhatBangLoaiPhong()
        {
            BangLoaiPhong?.Invoke();
        }

        public static event Action BangPhong;

        public static void CapNhatBangPhong()
        {
            BangPhong?.Invoke();
        }

        public static event Action BangLoaiDV;

        public static void CapNhatBangLoaiDV()
        {
            BangLoaiDV?.Invoke();
        }

        public static event Action BangDichVu;

        public static void CapNhatBangDichVu()
        {
            BangDichVu?.Invoke();
        }

        public static event Action BangKhach;

        public static void CapNhatBangKhach()
        {
            BangKhach?.Invoke();
        }

        public static event Action BookPhong;

        public static void CapNhatBookPhong()
        {
            BookPhong?.Invoke();
        }

        public static event Action CheckInOut;

        public static void CapNhatCheckInOut()
        {
            CheckInOut?.Invoke();
        }

        public static event Action PhongDatPhong;

        public static void CapNhatPhongDatPhong()
        {
            PhongDatPhong?.Invoke();
        }

        public static event Action BangHoaDonPhong;
        public static void CapNhatBangHoaDonPhong()
        {
            BangHoaDonPhong?.Invoke();
        }

        public static event Action BangHoaDonDatDV;
        public static void CapNhatBangHoaDonDatDV()
        {
            BangHoaDonDatDV?.Invoke();
        }

        public static event Action BangThongKe;
        public static void CapNhatBangThongKe()
        {
            BangThongKe?.Invoke();
        }

        public static void LockForm(Control NutHuyBo, Control NutXacNhan)
        {
            Form GetCurrentForm = Form.ActiveForm;

            if (!IsFieldNull(GetCurrentForm)) DisableControlsExcept(GetCurrentForm, NutHuyBo, NutXacNhan);
        }

        public static Boolean IsFieldNull(Object Field)
        {
            return Field == null;
        }

        public static void DisableControlsExcept(Control InputForm, Control NutHuyBo, Control NutXacNhan)
        {
            foreach (Control C in InputForm.Controls)
            {
                if (C != NutHuyBo && C != NutXacNhan)
                {
                    C.Enabled = false;

                    if (C.HasChildren) { DisableControlsExcept(C, NutHuyBo, NutXacNhan); }
                }
            }
        }

        public static void ShowError(String Message)

            => MessageBox.Show(Message, "Thông báo có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static DialogResult ShowAlert(String Message)

            => MessageBox.Show(Message, "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    }
}