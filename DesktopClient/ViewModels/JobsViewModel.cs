using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Core.DTOs;
using Core.Models.Enums;

namespace DesktopClient.ViewModels;

public class JobsViewModel
{
    public ObservableCollection<JobResponse> Jobs { get; } = new();
    private string _jobName = string.Empty;
    public string LogMessage
    {
        get => _jobName;
        set { _jobName = value; OnPropertyChanged(); }
    }

    public JobsViewModel()
    {
        //TODO: Load jobs from API or database
        Jobs.Add(new JobResponse { Id = Guid.NewGuid(), FileName = "Job A", Status = JobStatus.Queued });
        Jobs.Add(new JobResponse { Id = Guid.NewGuid(), FileName = "Job B", Status = JobStatus.InProgress });
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}