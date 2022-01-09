using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace M.H.S_Full_2._0
{
    public partial class Energia : Form
    {
        public Energia()
        {
            InitializeComponent();
            grafic();
        }

        private void Energia_Load(object sender, EventArgs e)
        {

        }

        public void grafic()
        {
            int i, Max, Div;

            var chart = chart1.ChartAreas[0];
            Max = Program.EnlongMax;
            chart1.Visible = true;
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 5;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = Program.EmP;

            if (Max > 120000)
            {
                Div = Convert.ToInt32(Max / 120000);
                chart.AxisY.Interval = (Div * 12000);
            }
            else
            {
                chart.AxisY.Interval = 10000;
            }

            chart.AxisX.Interval = 1;
   

            chart1.Series.Add("Energia Mecânica");
            chart1.Series["Energia Mecânica"].ChartType = SeriesChartType.Spline;
            chart1.Series["Energia Mecânica"].Color = Color.Yellow;
            chart1.Series[0].IsVisibleInLegend = false;

            for (i = 0; i < 5; i++)
            {
                chart1.Series["Energia Mecânica"].Points.AddXY((i), Program.EmP);
            }

            chart1.Series.Add("Energia Cinética");
            chart1.Series["Energia Cinética"].ChartType = SeriesChartType.Spline;
            chart1.Series["Energia Cinética"].Color = Color.Blue;
            chart1.Series[0].IsVisibleInLegend = false;

            for (i = 0; i < 5; i++)
            {
                chart1.Series["Energia Cinética"].Points.AddXY((i), Program.EcP[i]);
            }

            chart1.Series.Add("Energia Potêncial");
            chart1.Series["Energia Potêncial"].ChartType = SeriesChartType.Spline;
            chart1.Series["Energia Potêncial"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;

            for (i = 0; i < 5; i++)
            {
                chart1.Series["Energia Potêncial"].Points.AddXY((i), Program.EpP[i]);
            }
        }

        private void Energia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.JEnerg = 0;
        }
    }
}
