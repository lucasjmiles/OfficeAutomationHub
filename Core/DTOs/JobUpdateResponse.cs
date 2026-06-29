namespace Core.DTOs
{
    using Core.Models.Enums;
    public class JobUpdateResponse
    {
        public int Id { get; set; }
        public JobStatus Status { get; set; }
        public decimal ProgressPercentage { get; set; }
        public string? CurrentStep { get; set; }
        public string? Message { get; set; }
    }
}