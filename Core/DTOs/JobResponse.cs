namespace Core.DTOs
{
    using Core.Models.Enums;
    public class JobResponse
    {
        public int Id { get; set; }
        public required string FileName { get; set; } = string.Empty;
        public JobStatus Status { get; set; }
        public decimal ProgressPercentage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}