using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopClient;

using DesktopClient.ViewModels;
using Core.Models.Enums;
using Core.DTOs;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new JobsViewModel(); // simplest MVVM
    }
    private void UploadButton_Click(object sender, RoutedEventArgs e)
    {
        // Create OpenFileDialog 
        Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

        // Set filter for file extension and default file extension 
        dlg.DefaultExt = ".png";
        dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

        // Display OpenFileDialog by calling ShowDialog method 
        Nullable<bool> result = dlg.ShowDialog();

        // Get the selected file name and display in a TextBox 
        if (result.HasValue && result.Value)
        {
            // Open document 
            string filename = dlg.FileName;
            string fileNameOnly = System.IO.Path.GetFileName(filename);
            JobResponse newJob = new JobResponse
            {
                Id = Guid.NewGuid(),
                FileName = fileNameOnly,
                Status = JobStatus.Pending,
                ProgressPercentage = 0
            };
            ((JobsViewModel)DataContext).AddJob(newJob);
        }
    }
    private void ProcessButton_Click(object sender, RoutedEventArgs e)
    {
        // TODO: your logic
    }
    private void RefreshButton_Click(object sender, RoutedEventArgs e)
    {
        // TODO: your logic
    }
}