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
    public partial class ThongKeDuLieuTheoD : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongKeDuLieuTheoD()
        {
            InitializeComponent();

            HamChucNang.BangThongKe += FillDataForChart;
        }

        readonly HoaDonPhongBackend HoaDonHandle = new HoaDonPhongBackend();

        String EnableDynamic = "2DC";

        Int32 NumberOfDays = 0;

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

            List<Tuple<Int32, Int32>> DailyData = NewBillsList.GroupBy(Group => Group.NGAYTHANHTOAN.Day).Select(Merge => Tuple.Create(Merge.Key, Merge.Sum(Column => Column.GIATHANHTOAN))).ToList();

            for (int Day = 1; Day <= NumberOfDays; Day++)
            {
                Tuple<Int32, Int32> DayData = DailyData.FirstOrDefault(x => x.Item1 == Day);

                Int32 TotalThanhToan = DayData != null ? DayData.Item2 : 0000000;

                ColSeries.Points.Add(new SeriesPoint($"N{Day}", TotalThanhToan));
            }

            BieuDoPhongO.Series.Add(ColSeries);

            XYDiagram Diagram = BieuDoPhongO.Diagram as XYDiagram;

            Diagram.AxisX.Title.Text = "Ngày";

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

            ColSeries.View = new SideBySideBar3DSeriesView { ColorEach = true, BarWidth = 1 };

            ColSeries.LegendTextPattern = IntFormat;

            ColSeries.Label.TextPattern = IntFormat;

            ColSeries.LabelsVisibility = DefaultBoolean.True;

            List<Tuple<Int32, Int32>> DailyData = NewBillsList.GroupBy(Group => Group.NGAYTHANHTOAN.Day).Select(Merge => Tuple.Create(Merge.Key, Merge.Sum(Column => Column.GIATHANHTOAN))).ToList();

            for (int Item = 1; Item <= NumberOfDays; Item++)
            {
                Tuple<Int32, Int32> DayData = DailyData.FirstOrDefault(x => x.Item1 == Item);

                Int32 TotalThanhToan = DayData != null ? DayData.Item2 : 00000000;

                ColSeries.Points.Add(new SeriesPoint($"N{Item}", TotalThanhToan));
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

        private void ThangThongKe_EditValueChanged(object sender, EventArgs e)
        {
            NumberOfDays = GetDayNumber(((int)ThangThongKe.Value), ((int)NamThongKe.Value));

            if (ThangThongKe.Value < 0000001 || ThangThongKe.Value > 0000012)
            {
                ThangThongKe.Value = DateTime.Now.Month;
            }

            FillDataForChart();
        }

        private void NamThongKe_EditValueChanged(object sender, EventArgs e)
        {
            NumberOfDays = GetDayNumber(((int)ThangThongKe.Value), ((int)NamThongKe.Value));

            if (NamThongKe.Value < 0) NamThongKe.Value = DateTime.Now.Year;

            FillDataForChart();
        }

        private void BieuDoThongKeDuLieu_Loading(object sender, EventArgs e)

        => (ThangThongKe.Value, NamThongKe.Value) = (DateTime.Now.Month, DateTime.Now.Year);


        public void FillDataForChart()
        {
            List<HOADONPHONG_TBL> Bills = HoaDonHandle.HoaDonPhongTheoThang((Int32)ThangThongKe.Value, (Int32)NamThongKe.Value);

            if (EnableDynamic == "3DC")
            {
                KhoiTaoBieuDoPhong3D(Bills);
            }
            else
            {
                KhoiTaoBieuDoPhong2D(Bills);
            }
        }


        public Int32 GetDayNumber(Int32 Month, Int32 Year)
        {
            if (Month == 2)
            {
                return (Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0 ? 29 : 28;
            }
            else
            {
                return Month == 4 || Month == 6 || Month == 9 || Month == 11 ? 30 : 31;
            }
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