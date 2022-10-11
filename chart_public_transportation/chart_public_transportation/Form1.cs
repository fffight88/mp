using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart_public_transportation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {

            using (ChartEntities_PT db = new ChartEntities_PT())
            {
                
                chartPT.DataSource = db.bus_area.ToList();
                chartPT.ChartAreas[0].AxisY.Maximum = 75;
                chartPT.ChartAreas[0].AxisY.Minimum = 55;
                
                chartPT.Series["도심권"].XValueMember = "연도";
                chartPT.Series["도심권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["도심권"].YValueMembers = "도심권";
                chartPT.Series["도심권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동북권"].XValueMember = "연도";
                chartPT.Series["동북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동북권"].YValueMembers = "동북권";
                chartPT.Series["동북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서북권"].XValueMember = "연도";
                chartPT.Series["서북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서북권"].YValueMembers = "서북권";
                chartPT.Series["서북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서남권"].XValueMember = "연도";
                chartPT.Series["서남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서남권"].YValueMembers = "서남권";
                chartPT.Series["서남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동남권"].XValueMember = "연도";
                chartPT.Series["동남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동남권"].YValueMembers = "동남권";
                chartPT.Series["동남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }
        }

        private void btnSubway_Click(object sender, EventArgs e)
        {
            using (ChartEntities_PT db = new ChartEntities_PT())
            {

                chartPT.DataSource = db.subway_area.ToList();
                chartPT.ChartAreas[0].AxisY.Maximum = 75;
                chartPT.ChartAreas[0].AxisY.Minimum = 55;
                chartPT.Series["도심권"].XValueMember = "연도";
                chartPT.Series["도심권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["도심권"].YValueMembers = "도심권";
                chartPT.Series["도심권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동북권"].XValueMember = "연도";
                chartPT.Series["동북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동북권"].YValueMembers = "동북권";
                chartPT.Series["동북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서북권"].XValueMember = "연도";
                chartPT.Series["서북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서북권"].YValueMembers = "서북권";
                chartPT.Series["서북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서남권"].XValueMember = "연도";
                chartPT.Series["서남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서남권"].YValueMembers = "서남권";
                chartPT.Series["서남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동남권"].XValueMember = "연도";
                chartPT.Series["동남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동남권"].YValueMembers = "동남권";
                chartPT.Series["동남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }

        }

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            using (ChartEntities_PT db = new ChartEntities_PT())
            {
                chartPT.DataSource = db.taxi_area.ToList();
                chartPT.ChartAreas[0].AxisY.Maximum = 75;
                chartPT.ChartAreas[0].AxisY.Minimum = 44;
                chartPT.Series["도심권"].XValueMember = "연도";
                chartPT.Series["도심권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["도심권"].YValueMembers = "도심권";
                chartPT.Series["도심권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동북권"].XValueMember = "연도";
                chartPT.Series["동북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동북권"].YValueMembers = "동북권";
                chartPT.Series["동북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서북권"].XValueMember = "연도";
                chartPT.Series["서북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서북권"].YValueMembers = "서북권";
                chartPT.Series["서북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서남권"].XValueMember = "연도";
                chartPT.Series["서남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서남권"].YValueMembers = "서남권";
                chartPT.Series["서남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동남권"].XValueMember = "연도";
                chartPT.Series["동남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동남권"].YValueMembers = "동남권";
                chartPT.Series["동남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }

        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            using (ChartEntities_PT db = new ChartEntities_PT())
            {
                chartPT.DataSource = db.mean_area.ToList();
                chartPT.ChartAreas[0].AxisY.Maximum = 75;
                chartPT.ChartAreas[0].AxisY.Minimum = 54;
                chartPT.Series["도심권"].XValueMember = "연도";
                chartPT.Series["도심권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["도심권"].YValueMembers = "도심권";
                chartPT.Series["도심권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동북권"].XValueMember = "연도";
                chartPT.Series["동북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동북권"].YValueMembers = "동북권";
                chartPT.Series["동북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서북권"].XValueMember = "연도";
                chartPT.Series["서북권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서북권"].YValueMembers = "서북권";
                chartPT.Series["서북권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["서남권"].XValueMember = "연도";
                chartPT.Series["서남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["서남권"].YValueMembers = "서남권";
                chartPT.Series["서남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                chartPT.Series["동남권"].XValueMember = "연도";
                chartPT.Series["동남권"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartPT.Series["동남권"].YValueMembers = "동남권";
                chartPT.Series["동남권"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }
        }
    }
}
