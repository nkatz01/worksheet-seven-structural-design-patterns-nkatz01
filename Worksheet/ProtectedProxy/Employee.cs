namespace ProtectedProxy
{
    public class Employee : IStaff
    {
        public bool IsOwner()
        {
           return false;
        }

        public string GenerateDailyReport()
        {
            throw new System.NotImplementedException();
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}