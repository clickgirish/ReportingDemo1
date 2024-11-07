using Reporting.Common.Models;

namespace Reporting.Common
{
    public interface IReport
    {
        void PreProcess();
        Task<ReportResult> ProcessAsync(ReportPayload payload);
        void PostProcess();
        Task<ReportResult> Run(ReportPayload payload);
    }
}
