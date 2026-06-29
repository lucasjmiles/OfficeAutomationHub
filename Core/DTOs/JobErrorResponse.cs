namespace Core.DTOs
{
    public class JobErrorResponse
    {
        public int ErrorCode { get; set; }
        public string? Message { get; set; }
        public string? Details { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}