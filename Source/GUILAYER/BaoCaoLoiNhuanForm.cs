using DevExpress.XtraBars.Navigation;
using LOGICLAYER;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class BaoCaoLoiNhuanForm : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoLoiNhuanForm()
        {
            InitializeComponent();
        }

        public void OpenNewOrReopen(UserControl NewUserControl)
        {
            foreach (Control Sub in Screens.Controls)
            {
                if (Sub.GetType() == NewUserControl.GetType())
                {
                    Sub.BringToFront();

                    return;
                }
            }
            NewUserControl.Dock = DockStyle.Fill;

            Screens.Controls.Add(NewUserControl);

            NewUserControl.BringToFront();
        }

        private void Menu_ItemClick(object sender, ElementClickEventArgs e)
        {
            AccordionControlElement GetElement = e.Element;

            UserControl UCToOpen = null;

            switch (GetElement.Name)
            {
                case "ThongKeTheoM":

                    UCToOpen = new ThongKeDuLieuTheoM();

                    break;

                case "ThongKeTheoD":

                    UCToOpen = new ThongKeDuLieuTheoD();

                    break;

                case "PhanTichTheoM":

                    UCToOpen = new PhanTichDuLieuTheoM();

                    break;

                case "PhanTichTheoD":

                    UCToOpen = new PhanTichDuLieuTheoD();

                    break;
            }

            if (!HamChucNang.IsFieldNull(UCToOpen)) OpenNewOrReopen(UCToOpen);
        }
    }
}