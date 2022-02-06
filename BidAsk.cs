using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAnalysis.Model
{
    public class BidAsk
    {
        public DateTime DateTime { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public long Volume { get; set; }

        public BidAsk(DateTime dateTime, long volume, double bid, double ask)
        {
            DateTime = dateTime;
            Volume = volume;
            Bid = bid;
            Ask = ask;
        }
    }
}
