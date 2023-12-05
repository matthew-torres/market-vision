using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sys_Dev
{
    internal class candleStick
    {
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public long volume { get; set; }
        public DateTime date { get; set; }

        public candleStick(string lineString)
        {
            char[] separators = new char[] { ',', ' ', '"', '-' };
            string[] subs = lineString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string dateString = subs[2] + " " + subs[3] +", " + subs[4];
            DateTime tempDate;
            //if (DateTime.TryParseExact(dateString, "MMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDate))
            if (DateTime.TryParse(dateString, out tempDate))
            {
                date = tempDate;
            }
            else
            {
                // Handle the case where date parsing fails
                // You can throw an exception or set a default date, depending on your requirements
                date = DateTime.MinValue; // Set to a default value
            }

            Dictionary<string, int> map = new Dictionary<string, int>();
            int i = 1;
            map.Add("Jan", i++);
            map.Add("Feb", i++);
            map.Add("Mar", i++);
            map.Add("Apr", i++);
            map.Add("May", i++);
            map.Add("Jun", i++);
            map.Add("Jul", i++);
            map.Add("Aug", i++);
            map.Add("Sep", i++);
            map.Add("Oct", i++);
            map.Add("Nov", i++);
            map.Add("Dec", i++);

            bool success = false;


            double temp;
            success= double.TryParse(subs[5], out temp);
            open = temp;
            success = double.TryParse(subs[6], out temp);
            high = temp;
            success = double.TryParse(subs[7], out temp);
            low = temp;
            success = double.TryParse(subs[8], out temp);
            close = temp;

            long tempVol;
            success = long.TryParse(subs[9], out tempVol);
            volume = tempVol;

        }

        public candleStick(DateTime date, double open, double high, double low, double close, long volume)
        {
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }

        public static implicit operator candleStick(BindingList<candleStick> v)
        {
            throw new NotImplementedException();
        }
    }

}
