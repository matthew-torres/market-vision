using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sys_Dev
{
    internal abstract class Recognizer
    {
        public string Name { get; set; }
        protected int NumCandles { get; set; }


        // Constructor to set the properties
        public Recognizer(string name, int numCandles)
        {
            this.Name = name;
            this.NumCandles = numCandles;
        }

        public List<int> Recognize(List<SmartCandlestick> lscs) 
            /// Default recognize method to create a sub array of candlesticks depending on pattern specified
            /// returns list of indexes
        {
            List<int > results = new List<int>();
            for (int i = this.NumCandles; i < lscs.Count; i++)
            {
                List<SmartCandlestick> sublist = lscs.GetRange(i-this.NumCandles+1, this.NumCandles);
                if (RecognizePattern(sublist))
                {
                    results.Add(i);
                }
            }

            return results;
        }
        // abstract methd implemented by child classes to determine if specific pattern is present
        public abstract bool RecognizePattern(List<SmartCandlestick> sublist);
    }

}
