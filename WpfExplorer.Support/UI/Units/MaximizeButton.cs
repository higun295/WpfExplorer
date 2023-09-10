using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    public class MaximizeButton : Control
    {
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton), new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }
    }
}
