using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Software_Sys_Dev
{
    public partial class ChartForm : Form
    {
        internal ChartForm(List<SmartCandlestick> candlesticks, string filename, DateTime to, DateTime from)
            /// ChartForm Constructor accepting candlesticks, filename and date range. Calls LoadChart() in order
            /// to display new chart
        {
            InitializeComponent();
            this.candlesticks = candlesticks;
            this.filename = Path.GetFileNameWithoutExtension(filename); 
            this.to = to;
            this.from = from;
            dateTimePicker_From.Value = this.from;
            dateTimePicker_To.Value = this.to;
            Text = filename;
            InitRecognizers();
            PopulateCombobox();
            LoadChart();
        }

        private List<SmartCandlestick> candlesticks;
        private List<SmartCandlestick> dateRangeCandlesticks;
        private BindingList<SmartCandlestick> displayedCandlesticks = new BindingList<SmartCandlestick>(); // binding list for chart
        private string filename;
        private List<Recognizer> recognizers = new List<Recognizer>();
        DateTime to;
        DateTime from;
        List<int> patterns = new List<int>(); // stores indexes of matching candlestick patterns
    
        private void LoadChart()
            /// Stores and binds all the candlesticks in the specified user range
            /// Using the candlestick list accepted by the constructor, adds appropriate
            /// candlesticks to the displayedCandleSticks binding list and calls identifyPatterns()
        {
            displayedCandlesticks.Clear();
            chart_Stock.Titles.Clear(); // clear the title of the chart
            chart_Stock.Titles.Add(this.filename);
            dateRangeCandlesticks = new List<SmartCandlestick>(); // init list for candlesticks in specified range

            // loop through the list of candlesticks backwards to put in correct order
            foreach (SmartCandlestick c in candlesticks)
            {
                if (c.date >= this.to && c.date <= this.from)
                {
                    dateRangeCandlesticks.Add(c);
                }
            } 
            identifyPatterns(); // determine indexes for specific candlesitck pattern
            ConvertListToBindingList(dateRangeCandlesticks); // convert list used to calculate patterns into a binding list for chart display
            chart_Stock.DataSource = displayedCandlesticks; // bind candlesticks to chart
            chart_Stock.DataBind();
            chart_Stock.Update();
        }
        private void identifyPatterns()
            /// called within loadChart, uses index from combobox to select
            /// chooose correct recognizer
            /// recognizes patterns for specific candlestick range and stores returned list into 'patterns'
        {
            patterns.Clear(); // clear patterns of old indexes
            int recognizerIndex = comboBox_candleStickPatterns.SelectedIndex;
            if (recognizerIndex >= 0)
            {
                Recognizer r = recognizers[recognizerIndex];
                patterns = r.Recognize(dateRangeCandlesticks);
            }
        }

        private void ConvertListToBindingList(List<SmartCandlestick> cs)
        /// Accepts List<SmartCandlesticks> and adds each element to the BindingList 'displayedCandlesticks'
        {
            foreach (SmartCandlestick c in cs)
            {
                displayedCandlesticks.Add(c);
            }
        }
        private void AnnotatePatterns()
            /// called from comboBox_CandlestickPatterns_SelectedIndexChanged(), updates the annotations when
            /// the user selects a new pattern from the combo box. 
        {
            chart_Stock.Annotations.Clear(); // delete old annotations
            identifyPatterns();

                foreach (int index in patterns)
                {
                    SmartCandlestick candle = displayedCandlesticks[index];

                    DataPoint point = chart_Stock.Series["series_OHLC"].Points[index]; // create a datapoint from the points within the chart

                    RectangleAnnotation rect = new RectangleAnnotation(); // init rectangle annotation
                    rect.AnchorDataPoint = point; // bind the point to the annotations data point
                    rect.Width = 1;
                    rect.Height = 1;
                    rect.LineColor = Color.HotPink;
                    rect.LineWidth = 1;
                    rect.BackColor = Color.Transparent;

                    chart_Stock.Annotations.Add(rect); // add the annotation to the chart
                }
        }

        private void comboBox_candleStickPatterns_SelectedIndexChanged(object sender, EventArgs e)
            /// called when user selects new pattern in the combo box and updates the annotations on the chart
        {
            AnnotatePatterns();
        }

        private void button_UpdateChart_Click(object sender, EventArgs e)
            /// Called when update button is clicked
            /// Updates date values and called LoadChart() to update candlesticks in chart
        {
            this.from = dateTimePicker_From.Value;
            this.to = dateTimePicker_To.Value;
            LoadChart();
        }

        private void InitRecognizers()
        /// Initialize all pattern recognizers and store them in List<Recognizer> recognizers
        {
            recognizers.Add(new DojiRecognizer("Doji", 1));
            recognizers.Add(new DragonFlyDojiRecognizer("Dragonfly Doji", 1));
            recognizers.Add(new GravestoneDojiRecognizer("Gravestone Doji", 1));
            recognizers.Add(new MarubozuRecognizer("Marubozu", 1));
            recognizers.Add(new HammerRecognizer("Hammer", 1));
            recognizers.Add(new InvertedHammerRecognizer("Inverted Hammer", 1));
            recognizers.Add(new BullishRecognizer("Bullish", 1));
            recognizers.Add(new BearishRecognizer("Bearish", 1));
            recognizers.Add(new NeutralRecognizer("Neutral", 1));
            recognizers.Add(new BullishEngulfingRecognizer("Bullish Engulfing", 2));
            recognizers.Add(new BearishEngulfingRecognizer("Bearish Engulfing", 2));
            recognizers.Add(new BullishHaramiRecognizer("Bullish Harami", 2));
            recognizers.Add(new BearishHaramiRecognizer("Bearish Harami", 2));
            recognizers.Add(new PeakRecognizer("Peak", 3));
            recognizers.Add(new ValleyRecognizer("Valley", 3));
        }
        private void PopulateCombobox()
        /// Called in constructor to populate combo box with all recognizers within recognizers list
        {
            for (int i = 0; i < recognizers.Count; i++)
            {
                comboBox_candleStickPatterns.Items.Add(recognizers[i].Name);
            }
        }
    }
}
