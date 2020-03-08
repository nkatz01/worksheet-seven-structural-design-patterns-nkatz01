using System.Collections.Generic;

namespace ProtectedProxy
{
    public class ReportGenerator : IReportGenerator
    {
         

        public string GenerateDailyReport()
        {

             return $"returnLocation ID: 012\n Today's Date: Sun Sep 14 13:28:12 IST 2014\n  Total Pizza Sell: 112\n Total Sale: $2534\n Net Profit: $1985";
        }
    }
}