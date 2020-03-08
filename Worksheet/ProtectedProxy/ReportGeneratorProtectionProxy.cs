namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator reportGenerator ;
         private IStaff Staff { get; set; }

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            Staff = staff;
        }

        public string GenerateDailyReport()
        {
            if (this.Staff.IsOwner()) {
                if (this.reportGenerator == null)
                    this.reportGenerator = new ReportGenerator();
              return this.reportGenerator.GenerateDailyReport(); 
            }
            else
               return $"***************************************************************\nNot Authorised to view report.\n";
        }
    }
}