using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_FullStackedAreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl FullStackedAreaChart = new ChartControl();

            // Create two full-stacked area series.
            Series series1 = new Series("Series 1", ViewType.FullStackedArea);
            Series series2 = new Series("Series 2", ViewType.FullStackedArea);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(1, 10));
            series1.Points.Add(new SeriesPoint(2, 12));
            series1.Points.Add(new SeriesPoint(3, 14));
            series1.Points.Add(new SeriesPoint(4, 17));

            series2.Points.Add(new SeriesPoint(1, 15));
            series2.Points.Add(new SeriesPoint(2, 18));
            series2.Points.Add(new SeriesPoint(3, 25));
            series2.Points.Add(new SeriesPoint(4, 33));

            // Add both series to the chart.
            FullStackedAreaChart.Series.AddRange(new Series[] { series1, series2 });

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;
            series2.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((FullStackedAreaSeriesView)series1.View).Transparency = 50;
            ((FullStackedAreaSeriesView)series2.View).Transparency = 50;

            // Access the type-specific options of the diagram.
            ((XYDiagram)FullStackedAreaChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            FullStackedAreaChart.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            FullStackedAreaChart.Dock = DockStyle.Fill;
            this.Controls.Add(FullStackedAreaChart);
        }

    }
}