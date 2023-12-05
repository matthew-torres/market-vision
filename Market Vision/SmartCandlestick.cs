using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Sys_Dev
{
    internal class SmartCandlestick : candleStick
    {
        public SmartCandlestick(string csvLine) : base(csvLine) {
            calculateProperties();
            calculatePatterns();
        }

        public double range { get; set; }
        public double bodyRange { get; set; }
        public double topPrice { get; set; }
        public double bottomPrice { get; set; }
        public double topTail { get; set; }
        public double bottomTail { get; set; }

        public bool isBullish { get; set; }
        public bool isBearish { get; set; }
        public bool isNeutral { get; set; }
        public bool isDoji { get; set; }
        public bool isMarubozu { get; set; }
        public bool isDragonFlyDoji { get; set; }
        public bool isGravestoneDoji { get; set; }
        public bool isHammer { get; set; }
        public bool isInvertedHammer { get; set; }


        private void calculateProperties()
            /// called in the constructor to initiate higher level properties of a candlestick
        {
            range = high - low;
            bodyRange = Math.Abs(open - close);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            topTail = Math.Abs(high - topPrice);
            bottomTail = Math.Abs(bottomPrice - low);
        }

        private void calculatePatterns()
            /// Called in the constructor to calculate all candlestick patterns
        {
            // Bullish if the close price is higher than the open price
            isBullish = close > open;

            // Bearish if the open price is higher than the close price
            isBearish = open > close;

            // Neutral if the open and close prices are approximately equal
            //isNeutral = Math.Abs(open - close) <= (range * 0.05); // Threshold can be adjusted
            isNeutral = (bodyRange <= 6) && (Math.Abs(topTail - bottomTail) <= 10);

            // Doji - very small body
            isDoji = bodyRange <= (range * 0.05); // Threshold can be adjusted

            // Marubozu - little or no tail
            isMarubozu = (topTail <= (range * 0.05)) && (bottomTail <= (range * 0.05)); // Threshold can be adjusted

            // DragonFly Doji - Open and close at the high of the day
            isDragonFlyDoji = isDoji && (high == topPrice);

            // Gravestone Doji - Open and close at the low of the day
            isGravestoneDoji = isDoji && (low == bottomPrice);

            // Hammer - Small body at the upper end and long lower tail
            isHammer = (bottomTail <=0.10 *bodyRange && topTail >= 2*bodyRange);

            // Inverted Hammer - Small body at the lower end and long upper tail
            isInvertedHammer = (topTail <= 0.10 * bodyRange && bottomTail >= 2 * bodyRange);
        }


    }
}
