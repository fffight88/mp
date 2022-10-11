using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace chart_graph_gen
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Charting chart = new Charting();
            chart.CreateLineChart();
        }
    }

    class Charting
    {
        public string xLabel;
        public void CreateLineChart()
        {
            string imagepath = @"C:\Users\fffig\Desktop\mp\chart_graph_gen\chart_graph_gen\chart_graph_gen.png";
            Chart chart = new Chart();
            ChartArea CA = chart.ChartAreas.Add("A1");
            Series S1 = chart.Series.Add("S1");
            S1.ChartType = SeriesChartType.Line;
            S1.Points.AddXY(0, 2);
            S1.Points.AddXY(5, 10);
            chart.BackColor = Color.Transparent;
            CA.BackColor = Color.Transparent;
            CA.AxisX.Title = "X Label";
            CA.AxisY.Title = "Y Label";
            CA.AxisX.TitleAlignment = StringAlignment.Center;
            CA.AxisY.TitleAlignment = StringAlignment.Center;
            CA.AxisX.TitleFont = new Font("Arial", 15, FontStyle.Bold);
            CA.AxisY.TitleFont = new Font("Arial", 15, FontStyle.Bold);
            CA.AxisY.Maximum = 10;
            chart.Titles.Add("Title");
            chart.Titles.ElementAt(0).Font = new Font("Arial", 25, FontStyle.Bold);
            chart.Size = new Size(1000, 800);
            chart.Series["S1"].BorderWidth = 5;
            chart.AntiAliasing = AntiAliasingStyles.Graphics;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;
            chart.SaveImage(imagepath, ChartImageFormat.Png);
      
        }
    }
}
