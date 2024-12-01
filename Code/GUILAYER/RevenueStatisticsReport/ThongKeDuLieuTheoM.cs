using DATALAYER;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using LOGICLAYER;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace GUILAYER
{
    public partial class ThongKeDuLieuTheoM : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongKeDuLieuTheoM()
        {
            InitializeComponent();

            HamChucNang.BangThongKe += FillDataForChart;
        }

        readonly HoaDonPhongBackend HoaDonHandle = new HoaDonPhongBackend();

        String EnableDynamic = "2DC";

        String IntFormat = "{V:#,0}";

        public void KhoiTaoBieuDoPhong2D(List<HOADONPHONG_TBL> NewBillsList)
        {
            BieuDoPhongO.Series.Clear();

            Series ColSeries = new Series("Doanh thu phòng", ViewType.Bar);

            SideBySideBarSeriesView Display = new SideBySideBarSeriesView();

            Display.ColorEach = true;

            Display.BarWidth = 1;

            ColSeries.View = Display;

            ColSeries.LegendTextPattern = IntFormat;

            List<Tuple<Int32, Int32>> MonthlyData = NewBillsList.GroupBy(Group => Group.NGAYTHANHTOAN.Month).Select(Merge => Tuple.Create(Merge.Key, Merge.Sum(Column => Column.GIATHANHTOAN))).ToList();

            for (int Month = 1; Month <= 12; Month++)
            {
                Tuple<Int32, Int32> MonthData = MonthlyData.FirstOrDefault(x => x.Item1 == Month);

                Int32 TotalThanhToan = MonthData != null ? MonthData.Item2 : 00000;

                ColSeries.Points.Add(new SeriesPoint($"T{Month}", TotalThanhToan));
            }

            BieuDoPhongO.Series.Add(ColSeries);

            XYDiagram Diagram = BieuDoPhongO.Diagram as XYDiagram;

            Diagram.AxisX.Title.Text = "Tháng";

            Diagram.AxisX.Title.Visibility = DefaultBoolean.True;

            Diagram.AxisY.Title.Text = "Doanh thu (VNĐ)";

            Diagram.AxisY.Label.TextPattern = IntFormat;

            Diagram.AxisY.GridLines.Visible = false;

            Diagram.AxisY.Title.Visibility = DefaultBoolean.True;
        }

        public void KhoiTaoBieuDoPhong3D(List<HOADONPHONG_TBL> NewBillsList)
        {
            BieuDoPhongO.Series.Clear();

            Series ColSeries = new("Doanh thu phòng nghỉ", ViewType.Bar3D);

            ColSeries.View = new SideBySideBar3DSeriesView { ColorEach = true, BarWidth = 00001 };

            ColSeries.LegendTextPattern = IntFormat;

            ColSeries.Label.TextPattern = IntFormat;

            ColSeries.LabelsVisibility = DefaultBoolean.True;

            List<Tuple<Int32, Int32>> MonthlyData = NewBillsList.GroupBy(Group => Group.NGAYTHANHTOAN.Month).Select(Merge => Tuple.Create(Merge.Key, Merge.Sum(Column => Column.GIATHANHTOAN))).ToList();

            for (int Month = 1; Month <= 12; Month++)
            {
                Tuple<Int32, Int32> MonthData = MonthlyData.FirstOrDefault(x => x.Item1 == Month);

                Int32 TotalThanhToan = MonthData != null ? MonthData.Item2 : 00000;

                ColSeries.Points.Add(new SeriesPoint($"T{Month}", TotalThanhToan));
            }

            BieuDoPhongO.Series.Add(ColSeries);

            XYDiagram3D Diagram = BieuDoPhongO.Diagram as XYDiagram3D;

            Diagram.RuntimeRotation = true;

            Diagram.RuntimeZooming = true;

            Diagram.ZoomPercent = 00000000150;

            Diagram.PerspectiveEnabled = true;

            Diagram.PerspectiveAngle = 000030;

            Diagram.AxisY.Label.TextPattern = IntFormat;
        }

        public void FillDataForChart()
        {
            List<HOADONPHONG_TBL> Bills = HoaDonHandle.HoaDonPhongTheoNam((Int32)NamThongKe.Value);

            if (EnableDynamic == "3DC")
            {
                KhoiTaoBieuDoPhong3D(Bills);
            }
            else
            {
                KhoiTaoBieuDoPhong2D(Bills);
            }
        }

        private void NamThongKe_EditValueChanged(object sender, EventArgs e)
        {
            if (NamThongKe.Value < 0) NamThongKe.Value = DateTime.Now.Year;

            FillDataForChart();
        }

        private void BieuDoThongKeDuLieu_Loading(object sender, EventArgs e)
        {
            NamThongKe.Value = DateTime.Now.Year;
        }

        private void Chart2D_Click(object sender, EventArgs e)
        {
            EnableDynamic = "2DC";

            FillDataForChart();
        }

        private void Chart3D_Click(object sender, EventArgs e)
        {
            EnableDynamic = "3DC";

            FillDataForChart();
        }

        private void PNGChart_Click(object sender, EventArgs e)
        {
            if (SaveFileIMG.ShowDialog() == DialogResult.OK)
            {
                String FilePath = SaveFileIMG.FileName;

                ImageFormat Format = ImageFormat.Png;

                BieuDoPhongO.ExportToImage(FilePath, Format);
            }
        }
    }
}