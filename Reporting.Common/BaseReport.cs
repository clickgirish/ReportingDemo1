using Reporting.Common.Models;

namespace Reporting.Common
{
    public abstract class BaseReport : IReport
    {
        public virtual void PreProcess()
        {
        }

        public virtual Task<ReportResult> ProcessAsync(ReportPayload payload)
        {
            return (Task<ReportResult>)Task.CompletedTask;
        }

        public virtual void PostProcess()
        {
        }

        public Task<ReportResult> Run(ReportPayload payload)
        {
            PreProcess();
            var reportResultTask = ProcessAsync(payload);
            PostProcess();

            return reportResultTask;
        }
    }
}
