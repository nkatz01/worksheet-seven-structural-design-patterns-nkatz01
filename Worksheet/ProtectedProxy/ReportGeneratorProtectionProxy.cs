namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator reportGenerator;
         private IStaff Staff { get; set; }

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            reportGenerator = new ReportGenerator();
            Staff = staff;
        }

        public string GenerateDailyReport()
        {
            if (Staff.IsOwner() && reportGenerator == null)
             Staff.ReportGenerator= reportGenerator;

            return "Not Authorised to view report.";

        }
    }
}