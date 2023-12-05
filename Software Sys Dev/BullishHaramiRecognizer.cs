using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sys_Dev
{
    internal class BullishHaramiRecognizer : Recognizer
    {
        public BullishHaramiRecognizer(string name, int numCandles) : base(name, numCandles)
        {
        }
        public override bool RecognizePattern(List<SmartCandlestick> lscs)
        /// Accepts List of smartcandlesticks of the size numCandles
        /// returns boolean of whether pattern exists
        {
            SmartCandlestick left = lscs[0];
            SmartCandlestick right = lscs[1];
            return left.isBearish && right.isBullish && left.bodyRange < (0.25 * right.bodyRange);  // check whether first candlestick range is less than 25% of first candlesticks body
        }
    }
}
