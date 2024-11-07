namespace Reporting.Common.Models
{
    public class ReportParameter
    {
        public required string Name { get; set; }
        public required ReportParameterDataTypes DataType { get; set; }
        public bool IsRequired { get; set; }
    }
}
