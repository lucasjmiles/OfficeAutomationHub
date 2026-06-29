using Core.DTOs;

namespace Core.Interfaces
{
    public interface IJobQueueService
    {
        Task EnqueueJobAsync(JobResponse job);

        Task<JobResponse?> DequeueJobAsync();

        Task ProcessQueueAsync();
    }
}