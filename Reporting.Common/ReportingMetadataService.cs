using Reporting.Common.Models;

namespace Reporting.Common
{
    public class ReportingMetadataService : IReportingMetadataService
    {
        public ReportMetadata? GetReportMetadata(int reportId)
        {
            if (reportId == 1)
            {
                return new ReportMetadata
                {
                    ReportId = reportId.ToString(),
                    Category = "FinanceReports",
                    SubCategory = "RegulatoryReports",
                    ReportName = "SalesReport",
                    Parameters = new List<ReportParameter>
                    {
                        new() { Name = "Param1", DataType = ReportParameterDataTypes.String, IsRequired = true },
                        new() { Name = "Param2", DataType = ReportParameterDataTypes.Integer, IsRequired = false },
                        new() { Name = "Param3", DataType = ReportParameterDataTypes.Decimal, IsRequired = true }
                    }
                };
            }
            else if (reportId == 2)
            {
                return new ReportMetadata
                {
                    ReportId = reportId.ToString(),
                    Category = "FinanceReports",
                    SubCategory = "RegulatoryReports",
                    ReportName = "AuditReport",
                    Parameters = new List<ReportParameter>
                    {
                        new() { Name = "From", DataType = ReportParameterDataTypes.DateTime, IsRequired = true },
                        new() { Name = "To", DataType = ReportParameterDataTypes.DateTime, IsRequired = true }
                    }
                };
            }
            else
            {
                return null;
            }
        }
    }
}
