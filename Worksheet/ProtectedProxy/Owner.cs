namespace ProtectedProxy
{
    public class Owner : IStaff
    {
        public bool IsOwner()
        {
          return true;
        }

        public string GenerateDailyReport()
        {
            throw new System.NotImplementedException();
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}