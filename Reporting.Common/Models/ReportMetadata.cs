namespace Reporting.Common.Models
{
    public class ReportMetadata
    {
        public required string ReportId { get; set; }
        public required string ReportName { get; set; }
        public required string Category { get; set; }
        public required string SubCategory { get; set; }
        public List<ReportParameter>? Parameters { get; set; }
    }
}