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
    }
}