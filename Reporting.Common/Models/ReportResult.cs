namespace Reporting.Common.Models
{
    public class ReportResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
        public Dictionary<string, object>? Metadata { get; set; }
    }
}
