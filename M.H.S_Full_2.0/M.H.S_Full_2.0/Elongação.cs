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
    public partial class Elongação : Form
    {
        public Elongação()
        {
            InitializeComponent();
            grafic();
        }

        private void Elongação_Load(object sender, EventArgs e)
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
            if (Max <= 500)
            {
                chart.AxisY.Minimum = -500;
                chart.AxisY.Maximum = 500;
            }
            else
            {
                chart.AxisY.Minimum = -Max - 100;
                chart.AxisY.Maximum = Max + 100;
            }

            if (Max <= 1000)
            {
                chart.AxisY.Interval = 100;
            }
            else
            {
                Div = Convert.ToInt32(Max / 500);
                chart.AxisY.Interval = (Div * 100);
            }

            chart.AxisX.Interval = 1;
            chart1.Series.Add("Elongação");
            chart1.Series["Elongação"].ChartType = SeriesChartType.Spline;
            chart1.Series["Elongação"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;

            for (i = 0; i < 5; i++)
            {
                chart1.Series["Elongação"].Points.AddXY((i), Program.ElongP[i]);
            }
        }

        private void Elongação_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.JEnlog = 0;
        }
    }
}

