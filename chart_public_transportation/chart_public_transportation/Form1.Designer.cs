using System;

namespace chart_public_transportation
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartPT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnSubway = new System.Windows.Forms.Button();
            this.btnTaxi = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPT)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPT
            // 
            this.chartPT.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chartPT.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chartPT.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartPT.Legends.Add(legend2);
            this.chartPT.Location = new System.Drawing.Point(44, 35);
            this.chartPT.Name = "chartPT";
            this.chartPT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "도심권";
            series6.YValuesPerPoint = 2;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "동북권";
            series7.YValuesPerPoint = 2;
            series8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "서북권";
            series8.YValuesPerPoint = 2;
            series9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "서남권";
            series9.YValuesPerPoint = 2;
            series10.BorderColor = System.Drawing.Color.Red;
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "동남권";
            series10.YValuesPerPoint = 2;
            this.chartPT.Series.Add(series6);
            this.chartPT.Series.Add(series7);
            this.chartPT.Series.Add(series8);
            this.chartPT.Series.Add(series9);
            this.chartPT.Series.Add(series10);
            this.chartPT.Size = new System.Drawing.Size(1490, 615);
            this.chartPT.TabIndex = 1;
            this.chartPT.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            title2.Name = "Title1";
            title2.Text = "권역별 교통수단 이용만족도 변화";
            this.chartPT.Titles.Add(title2);
            // 
            // btnBus
            // 
            this.btnBus.Location = new System.Drawing.Point(906, 684);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(124, 48);
            this.btnBus.TabIndex = 2;
            this.btnBus.Text = "버스";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnSubway
            // 
            this.btnSubway.Location = new System.Drawing.Point(1072, 684);
            this.btnSubway.Name = "btnSubway";
            this.btnSubway.Size = new System.Drawing.Size(124, 48);
            this.btnSubway.TabIndex = 2;
            this.btnSubway.Text = "지하철";
            this.btnSubway.UseVisualStyleBackColor = true;
            this.btnSubway.Click += new System.EventHandler(this.btnSubway_Click);
            // 
            // btnTaxi
            // 
            this.btnTaxi.Location = new System.Drawing.Point(1247, 684);
            this.btnTaxi.Name = "btnTaxi";
            this.btnTaxi.Size = new System.Drawing.Size(124, 48);
            this.btnTaxi.TabIndex = 2;
            this.btnTaxi.Text = "택시";
            this.btnTaxi.UseVisualStyleBackColor = true;
            this.btnTaxi.Click += new System.EventHandler(this.btnTaxi_Click);
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(1410, 684);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(124, 48);
            this.btnMean.TabIndex = 2;
            this.btnMean.Text = "평균";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 764);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.btnTaxi);
            this.Controls.Add(this.btnSubway);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.chartPT);
            this.Name = "Form1";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartPT)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPT;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnSubway;
        private System.Windows.Forms.Button btnTaxi;
        private System.Windows.Forms.Button btnMean;
    }
}

