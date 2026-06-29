// =============================
// Core/Interfaces/IJobService.cs
// =============================

using Core.DTOs;

namespace Core.Interfaces;

public interface IJobService
{
    Task<JobResponse> CreateJobAsync(JobCreateRequest request);

    Task<JobResponse?> GetJobAsync(Guid jobId);

    Task<IEnumerable<JobResponse>> GetAllJobsAsync();

    Task<JobResponse> UpdateJobAsync(JobUpdateResponse request);

    Task<bool> DeleteJobAsync(Guid jobId);
}