using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Location.Local.ViewModels
{
    public partial class LocationContentViewModel : ObservableBase
    {
        private readonly NavigatorService _navigatorService;

        public LocationContentViewModel(NavigatorService navigatorService)
        {
            _navigatorService = navigatorService;
        }

        [RelayCommand]
        public void Up()
        {
            _navigatorService.GoToParent();
        }

        [RelayCommand]
        public void Undo()
        {
            _navigatorService.GoBack();
        }

        [RelayCommand]
        public void Redo()
        {
            _navigatorService.GoForward();
        }
    }
}