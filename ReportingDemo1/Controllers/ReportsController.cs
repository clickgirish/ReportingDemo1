using Microsoft.AspNetCore.Mvc;
using Reporting.Common;
using Reporting.Common.Models;

namespace ReportingDemo1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController(ReportFactory factory, IReportingMetadataService metadataService) : ControllerBase
    {
        [HttpPost("Execute")]
        public async Task<IActionResult> ExecuteAsync([FromBody] ReportPayload payload)
        {
            var report = factory.GetReportInstance(payload.ReportName);

            if (report == null)
            {
                return NotFound($"{payload.ReportName} not found.");
            }

            var result = await report.Run(payload);

            return Ok(result);
        }

        [HttpGet("GetMetadata")]
        public IActionResult GetMetadata(int reportId)
        {
            var metadata = metadataService.GetReportMetadata(reportId);

            if (metadata == null)
                return NotFound("Metadata not found");

            return Ok(metadata);
        }
    }
}
