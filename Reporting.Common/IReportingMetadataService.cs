using Reporting.Common.Models;

namespace Reporting.Common
{
    public interface IReportingMetadataService
    {
        ReportMetadata? GetReportMetadata(int reportId);
    }
}
