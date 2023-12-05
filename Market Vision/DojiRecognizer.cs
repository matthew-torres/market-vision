using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sys_Dev
{
    internal class DojiRecognizer : Recognizer
    {
        public DojiRecognizer(string name, int numCandles) : base(name, numCandles)
        {
        }
        public override bool RecognizePattern(List<SmartCandlestick> lscs)
        /// Accepts List of smartcandlesticks of the size numCandles
        /// returns boolean of whether pattern exists
        {
            return lscs[0].isDoji;
        }
    }
}
