using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using System.Collections.Generic;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        private readonly FileService _fileService;
        private readonly NavigatorService _navigatorService;

        public List<FolderInfo> Roots { get; init; }

        public MainContentViewModel(FileService fileService, NavigatorService navigatorService)
        {
            _fileService = fileService;
            _navigatorService = navigatorService;
            _navigatorService.LocationChanged += _navigatorService_LocationChanged;

            Roots = fileService.GenerateRootNodes();
        }

        private void _navigatorService_LocationChanged(object? sender, LocationChangedEventArgs e)
        {
        }

        [RelayCommand]
        private void FolderChanged(FolderInfo folderInfo)
        {
            _fileService.RefreshSubdirectories(folderInfo);
            _navigatorService.ChangeLocation(folderInfo);
        }
    }
}