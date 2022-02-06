using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAnalysis.Model
{
    public class BidAskResponse : DataResponse
    {
        public OHLC? Bid { get; set; }
        public OHLC? Ask { get; set; }
    }

    public class HistoricalDataResponse : DataResponse
    {
        public IList<OHLC> OHLC { get; set; } = new List<OHLC>();
    }

    public class DataResponse
    {
        public string Instrument { get; set; } = "";
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public long Volume { get; set; }
    }
}
