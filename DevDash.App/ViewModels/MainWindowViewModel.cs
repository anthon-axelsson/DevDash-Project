using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevDash.App.Views;

namespace DevDash.App.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView = new();
    private readonly SnippetVaultViewModel _snippetVaultView = new();

    [ObservableProperty]
    private string _pageTitle = "DevDash - Dashboard";

    [ObservableProperty]
    private ViewModelBase _currentView; 
    
    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;
    [RelayCommand]
    private void GoToSnippetVault() => CurrentView = _snippetVaultView;
    
    public MainWindowViewModel()
    {
        CurrentView = _homeView;
    }

}
