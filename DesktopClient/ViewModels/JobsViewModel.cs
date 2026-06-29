using System.Collections.ObjectModel;
using Core.DTOs;
using Core.Models.Enums;

namespace DesktopClient.ViewModels;

public class JobsViewModel
{
    public ObservableCollection<JobResponse> Jobs { get; } = new();
    public JobsViewModel()
    {
        Jobs.Add(new JobResponse { Id = Guid.NewGuid(), FileName = "Job A", Status = JobStatus.Queued });
        Jobs.Add(new JobResponse { Id = Guid.NewGuid(), FileName = "Job B", Status = JobStatus.InProgress });
    }
}