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

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new JobsViewModel(); // simplest MVVM
    }
    private void UploadButton_Click(object sender, RoutedEventArgs e)
    {
        // TODO: your logic
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