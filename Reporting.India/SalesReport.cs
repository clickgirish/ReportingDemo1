using Reporting.Common;
using Reporting.Common.Models;

namespace Reporting.India
{
    public class SalesReport : BaseReport
    {
        public override Task<ReportResult> ProcessAsync(ReportPayload payload)
        {
            var reportResult = base.ProcessAsync(payload);

            // India specific logic

            return reportResult;
        }
    }
}
