using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionGiveawayTracker
{
    public class GiveawayRecord
    {
        public DateTime Date {  get; set; }
        public string Shift { get; set; }
        public int LineNumber { get; set; }
        public string Product { get; set; }
        public decimal GiveawayKg { get; set; }

        public GiveawayRecord()
        {
            Shift = "";
            Product = "";


        }
        public GiveawayRecord(DateTime date, String shift, int lineNumber, string product, decimal giveawayKg)
        {
            Date = date;
            Shift = shift;
            LineNumber = lineNumber;
            Product = product;
            GiveawayKg = giveawayKg;
        }
     }
}
