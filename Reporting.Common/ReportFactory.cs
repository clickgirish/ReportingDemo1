namespace Reporting.Common
{
    public class ReportFactory(IServiceProvider serviceProvider)
    {
        public IReport? GetReportInstance(string reportName)
        {
            var reportType = Type.GetType($"Reporting.India.{reportName}Report");

            if (reportType == null)
            {
                return null;
            }

            return serviceProvider.GetService(reportType) as IReport;
        }
    }
}
