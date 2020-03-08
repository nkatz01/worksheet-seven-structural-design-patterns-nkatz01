using System.Collections.Generic;

namespace ProtectedProxy
{
    public class ReportGenerator : IReportGenerator
    {
         

        public string GenerateDailyReport()
        {

            return $"********************Location X Daily Report ********************\nreturnLocation ID: 012\nToday's Date: Sun Sep 14 13:28:12 IST 2014\nTotal Pizza Sell: 112\nTotal Sale: $2534\nNet Profit: $1985\n";
           
        }
    }
}