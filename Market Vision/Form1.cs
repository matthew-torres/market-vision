using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Software_Sys_Dev
{
    public partial class Form1 : Form
    {
        private BindingList<SmartCandlestick> candleSticks { get; set; }
        List<SmartCandlestick> tempList = new List<SmartCandlestick>(1024);
        public Form1()
        {
            InitializeComponent();
        }

        private void button_loadStock_Click(object sender, EventArgs e)
            /*
             * This event handleer method executes when the load stock button is clicked on the window form
             * Opens a file dialog to allow the user to select a specific csv file populated with stock data
             * and reads each line to store them into a binding list
             * It calls the method updateList() to then populate the candlestick chart
             */
        {
            // file dialog allowing the user to select a csv file
            this.openFileDialog_loadStock.ShowDialog();
        }

        private List<SmartCandlestick> loadCandleSticksFromFile(string filename)
            /// accepts a string filename and returns a list of smartcandlesticks for the given file
            /// Method uses csv reader to loop through each line of a csv file and convert that line to 
            /// a smartcandlestick
        {
                List<SmartCandlestick> resultsList = new List<SmartCandlestick>(1024);
                string line; // declare a string for each line to be read
                string referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\""; // string of headers used to verfiy file format

                using (StreamReader r = new StreamReader(filename)) // stream reader context in order to read each line of the file
                {
                    string header = r.ReadLine(); // read first line of file to check headers
                    candleSticks = new BindingList<SmartCandlestick>(); // init candlestick bindinglist
                    tempList.Clear(); // clear the templist binding list of older candlesitcks


                    if (header == referenceString) // verify headers
                    {

                        while ((line = r.ReadLine()) != null)
                        {
                            // instantiate a new candlestick
                            SmartCandlestick c = new SmartCandlestick(line);
                            // add candlesitck to the temp list of candlesticks
                            resultsList.Add(c);
                        }
                    }
                }

            resultsList.Reverse();
            return resultsList;
            }

        private List<List<SmartCandlestick>> loadCandleSticks(string[] filenames)

            /// Accepts a list of filenames and returns a list of lists of candlesticks per file
            /// method calls loadCanleSticksFromFile() for each file name and adds returned list to the list of list
        {
            List<List<SmartCandlestick>> listOfListOfCandlesticks = new List<List<SmartCandlestick>>(filenames.Length); // init list of lists

            foreach (string filename in filenames)
            {
                listOfListOfCandlesticks.Add(loadCandleSticksFromFile(filename)); // for each file name, retrieve candlesticks from file
            }
            return listOfListOfCandlesticks;
        }

        private void displayChart(string filename, List<SmartCandlestick> listCandleSticks, DateTime from, DateTime to)
            /// accepts filename, list of candlesticks and date range in order to init a new chart and display it
        {
            ChartForm chartForm = new ChartForm(listCandleSticks, filename, to, from); // creates new chart form passing parameters to constructor
            chartForm.Show();
        }

        private void openFileDialog_loadStock_FileOk(object sender, CancelEventArgs e)
            /// displayed when user clicks load stock button
            /// Allows user to select multiple files which are then passed to loadCandleSticks()
            /// iteratively displays each file selected and creates chart 
        {
            
            List<List<SmartCandlestick>> listOfListOfCandlesticks = loadCandleSticks(openFileDialog_loadStock.FileNames);
            for (int i = 0; i < openFileDialog_loadStock.FileNames.Length; i++)
            {
                displayChart(openFileDialog_loadStock.FileNames[i], listOfListOfCandlesticks[i], dateTimePicker_From.Value, dateTimePicker_To.Value);
            }
        }
    }
}
