using System.Windows.Controls;
using System.Windows;

namespace WpfExplorer.Main.UI.Units
{
    public class FolderTreeItem : TreeViewItem
    {
        static FolderTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeItem), new FrameworkPropertyMetadata(typeof(FolderTreeItem)));
        }
    }
}
