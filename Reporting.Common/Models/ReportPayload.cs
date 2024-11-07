namespace Reporting.Common.Models
{
    public class ReportPayload
    {
        public required string ReportCategory { get; set; }
        public required string ReportSubCategory { get; set; }
        public required string ReportName { get; set; }
        public required Dictionary<string, object>? Parameters { get; set; }
        public int MetadataId { get; set; }
        public string? ReportId { get; set; }
    }
}
