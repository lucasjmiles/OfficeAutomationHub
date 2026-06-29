namespace Core.Models
{
    using Core.Models.Enums;
    public class Job
    {
        public Guid Id { get; set; }
        public required string FileName { get; set; } = string.Empty;
        public required string InputFilePath { get; set; } = string.Empty;
        public string? OutputFilePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public JobStatus Status { get; set; }
        public decimal ProgressPercentage { get; set; }
        public string? ErrorMessage { get; set; }
    }
}