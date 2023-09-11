using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new DarkWindow();
        }
    }
}
