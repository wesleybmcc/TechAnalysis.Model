using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAnalysis.Model
{
    public class OHLC
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public bool IsTick { get; set; }
        public string Symbol { get; set; } = "";

        public OHLC() { }

        public OHLC(string symbol, DateTime startDateTime, DateTime endDateTime, double open, double high, double low, double close)
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            IsTick = startDateTime.Ticks == endDateTime.Ticks;
            Open = open;
            High = high;
            Low = low;
            Close = close;
        }
    }
}