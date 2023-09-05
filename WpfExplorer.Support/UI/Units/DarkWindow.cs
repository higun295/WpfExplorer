using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkWindow : Control
    {
        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }
    }
}
