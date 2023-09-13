using Jamesnet.Wpf.Mvvm;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public class ExplorerViewModel : ObservableBase
    {
        public string TestTitle { get; init; }

        public ExplorerViewModel()
        {
            TestTitle = "WPF INSIDE OUT";
        }
    }
}
