using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sys_Dev
{
    internal class BearishHaramiRecognizer : Recognizer
    {
            public BearishHaramiRecognizer(string name, int numCandles) : base(name, numCandles)
            {
            }
            public override bool RecognizePattern(List<SmartCandlestick> lscs)
            /// Accepts List of smartcandlesticks of the size numCandles
            /// returns boolean of whether pattern exists
        {
            SmartCandlestick left = lscs[0];
                SmartCandlestick right = lscs[1];
                return left.isBullish && right.isBearish && (left.bodyRange * 0.25) > right.bodyRange; // check whether second candlestick range is less than 25% of first candlesticks body
            }
    }
}
