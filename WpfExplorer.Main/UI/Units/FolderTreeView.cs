using System.Windows.Controls;
using System.Windows;

namespace WpfExplorer.Main.UI.Units
{
    public class FolderTreeView : TreeView
    {
        static FolderTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeView), new FrameworkPropertyMetadata(typeof(FolderTreeView)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FolderTreeItem();
        }
    }
}
