using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ChuongThongBaoForm : DevExpress.XtraEditors.XtraForm
    {
        public ChuongThongBaoForm()
        {
            InitializeComponent();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form_LocationChanged(object sender, EventArgs e)
        {
            Rectangle WorkingArea = Screen.GetWorkingArea(this);

            Int32 NewX = Math.Max(WorkingArea.Left, Math.Min(Left, WorkingArea.Right - Width));

            Int32 NewY = Math.Max(WorkingArea.Top, Math.Min(Top, WorkingArea.Bottom - Height));

            if (Left != NewX || Top != NewY)
            {
                Location = new Point(NewX, NewY);
            }
        }

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr HWND, Int32 Msg, Int32 WParam, Int32 LParam);

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        private const int HTCAPTION = 0x2;

        private const int WM_NCLBUTTONDOWN = 0xA1;
    }
}