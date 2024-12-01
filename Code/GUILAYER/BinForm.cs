using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class BinForm : DevExpress.XtraEditors.XtraForm
    {
        public BinForm() { InitializeComponent(); }

        public event Action<DataGridViewRow> OnRowDroppedBangPhongO;

        public event Action<DataGridViewRow> OnRowDroppedBangDichVu;

        private void Image_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Image_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewRow Row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));

            DataGridViewColumnCollection GetListDroppedColumns = Row.DataGridView.Columns;

            if (GetListDroppedColumns.Contains("MAPHONGODC"))
            {
                OnRowDroppedBangPhongO?.Invoke(Row);
            }

            else

            if (GetListDroppedColumns.Contains("MADICHVUDC"))
            {
                OnRowDroppedBangDichVu?.Invoke(Row);
            }
        }
    }
}