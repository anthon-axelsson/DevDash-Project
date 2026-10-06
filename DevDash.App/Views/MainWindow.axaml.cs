using Avalonia.Controls;
using DevDash.App.ViewModels;

namespace DevDash.App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new MainWindowViewModel();
    }
}