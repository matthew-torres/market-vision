namespace Software_Sys_Dev
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.comboBox_candleStickPatterns = new System.Windows.Forms.ComboBox();
            this.button_UpdateChart = new System.Windows.Forms.Button();
            this.label_Patterns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Stock
            // 
            chartArea3.AlignWithChartArea = "chartarea_Volume";
            chartArea3.AxisX.ScaleView.Zoomable = false;
            chartArea3.AxisX.Title = "Date";
            chartArea3.AxisY.Title = "Price";
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.Name = "chartarea_OHLC";
            chartArea4.AlignWithChartArea = "chartarea_OHLC";
            chartArea4.AxisX.Title = "Date";
            chartArea4.AxisY.Title = "Volume";
            chartArea4.Name = "chartarea_Volume";
            this.chart_Stock.ChartAreas.Add(chartArea3);
            this.chart_Stock.ChartAreas.Add(chartArea4);
            this.chart_Stock.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart_Stock.Legends.Add(legend2);
            this.chart_Stock.Location = new System.Drawing.Point(0, 193);
            this.chart_Stock.Name = "chart_Stock";
            series3.ChartArea = "chartarea_OHLC";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "series_OHLC";
            series3.XValueMember = "date";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.YValueMembers = "high, low, open, close";
            series3.YValuesPerPoint = 4;
            series4.ChartArea = "chartarea_Volume";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "series_Volume";
            series4.XValueMember = "date";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series4.YValueMembers = "volume";
            this.chart_Stock.Series.Add(series3);
            this.chart_Stock.Series.Add(series4);
            this.chart_Stock.Size = new System.Drawing.Size(1719, 573);
            this.chart_Stock.TabIndex = 12;
            this.chart_Stock.Text = "chart_Stock";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Location = new System.Drawing.Point(726, 65);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(38, 16);
            this.label_From.TabIndex = 21;
            this.label_From.Text = "From";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Location = new System.Drawing.Point(726, 14);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(24, 16);
            this.label_To.TabIndex = 20;
            this.label_To.Text = "To";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(726, 89);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker_From.TabIndex = 19;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(726, 36);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker_To.TabIndex = 18;
            this.dateTimePicker_To.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // comboBox_candleStickPatterns
            // 
            this.comboBox_candleStickPatterns.FormattingEnabled = true;
            this.comboBox_candleStickPatterns.Location = new System.Drawing.Point(1017, 38);
            this.comboBox_candleStickPatterns.Name = "comboBox_candleStickPatterns";
            this.comboBox_candleStickPatterns.Size = new System.Drawing.Size(121, 24);
            this.comboBox_candleStickPatterns.TabIndex = 22;
            this.comboBox_candleStickPatterns.SelectedIndexChanged += new System.EventHandler(this.comboBox_candleStickPatterns_SelectedIndexChanged);
            // 
            // button_UpdateChart
            // 
            this.button_UpdateChart.Location = new System.Drawing.Point(745, 127);
            this.button_UpdateChart.Name = "button_UpdateChart";
            this.button_UpdateChart.Size = new System.Drawing.Size(197, 23);
            this.button_UpdateChart.TabIndex = 23;
            this.button_UpdateChart.Text = "Update Chart";
            this.button_UpdateChart.UseVisualStyleBackColor = true;
            this.button_UpdateChart.Click += new System.EventHandler(this.button_UpdateChart_Click);
            // 
            // label_Patterns
            // 
            this.label_Patterns.AutoSize = true;
            this.label_Patterns.Location = new System.Drawing.Point(1017, 16);
            this.label_Patterns.Name = "label_Patterns";
            this.label_Patterns.Size = new System.Drawing.Size(56, 16);
            this.label_Patterns.TabIndex = 24;
            this.label_Patterns.Text = "Patterns";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 766);
            this.Controls.Add(this.label_Patterns);
            this.Controls.Add(this.button_UpdateChart);
            this.Controls.Add(this.comboBox_candleStickPatterns);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.dateTimePicker_From);
            this.Controls.Add(this.dateTimePicker_To);
            this.Controls.Add(this.chart_Stock);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Stock;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.ComboBox comboBox_candleStickPatterns;
        private System.Windows.Forms.Button button_UpdateChart;
        private System.Windows.Forms.Label label_Patterns;
    }
}