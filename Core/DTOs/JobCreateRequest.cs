namespace Core.DTOs
{
    public class JobCreateRequest
    {
        public required string FileName { get; set; } = string.Empty;
        public required string InputFilePath { get; set; } = string.Empty;
        public required string RequestedBy { get; set; } = string.Empty;
        public required string Notes { get; set; }
    }
}